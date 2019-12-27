//filename : dayserver_daemon.c
//This program will make the server program run in the background //as a daemon.


#include "unp.h"
#include "tcp_listen.c"
//#include "daemon_init.c"
#include <time.h>
#include <syslog.h>
#define MAXFD 64

int daemon_init(const char *pname, int facility)
{
	int i;
	pid_t pid;

	if((pid=fork())<0)
		return -1;	
	else if(pid)
		exit(0);	//parent terminates

	//1st child continues
	if (setsid()<0)		//become session leader
		return -1;

	signal(SIGHUP, SIG_IGN);

	if((pid=fork())<0)
		return -1;	
	else if(pid)
		exit(0);	//1st child terminates

	//2nd child continues

	chdir("/");

	//umask(0);	//clear file mode creation mask

	for(i=0; i<MAXFD; i++)
		close(i);

	//redirect stdin, stdout and stderr to /dev/null
	open("dev/null", O_RDONLY);
	open("dev/null", O_RDWR);
	open("dev/null", O_RDWR);
	

	openlog(pname, LOG_PID, LOG_USER);

	return 0;	//success
}

int tcp_listen(const char *host, const char *serv, socklen_t *addrlenp)
{
	int listenfd, n;
	const int on =1;
	struct addrinfo hints, *res, *ressave;

	bzero(&hints, sizeof(struct addrinfo));
	hints.ai_flags=AI_PASSIVE;
	hints.ai_family=AF_UNSPEC;
	hints.ai_socktype=SOCK_STREAM;

	if((n=getaddrinfo(host, serv, &hints, &res))!=0)
	{
		printf("\ntcp_listen error for %s, %s: %s", host, serv, gai_strerror(n));
		exit(1);
	}
	ressave=res;
	do
	{
		listenfd=socket(res->ai_family, res->ai_socktype, res->ai_protocol);
		if(listenfd<0)
			continue;	//error, try next one

		setsockopt(listenfd, SOL_SOCKET, SO_REUSEADDR, &on, sizeof(on));

		if(bind(listenfd, res->ai_addr, res->ai_addrlen)==0)
			break;	//success

		close(listenfd);	//bind error, try next one
	}while((res=res->ai_next)!=NULL);

	if(res==NULL)
		printf("\n tcp_listen error for %s, %s\n", host, serv);

	listen(listenfd, LISTENQ);
	if(addrlenp)
		*addrlenp = res->ai_addrlen;	//return size of protocol address

	freeaddrinfo(ressave);

	return(listenfd);
}


int main(int argc, char **argv)
{
	int listenfd, connfd;
	socklen_t addrlen, len;
	char buff[MAXLINE];
	time_t ticks;
	struct sockaddr *cliaddr;

	if(argc<2 || argc>3)
	{
		printf("usage: ./dayserver_daemon.out [<host>] <service/port>\n");
		exit(1);
	}

	daemon_init(argv[0], 0);

	if(argc==2)
		listenfd=tcp_listen(NULL, argv[1], &addrlen);
	else
		listenfd=tcp_listen(argv[1], argv[2], &addrlen);
	
	cliaddr=malloc(addrlen);

	for(;;)
	{
		len=addrlen;
		connfd=accept(listenfd, cliaddr, &len);
		ticks=time(NULL);
		snprintf(buff, sizeof(buff), "%s\r\n", ctime(&ticks));
		write(connfd, buff, strlen(buff));
		close(connfd);
	}
}

//Note: compile and run the server program. You will notice that //there is no terminal used by this program. 
//compile and run the client program. It will work. Since this //program is acting as a daemon.

