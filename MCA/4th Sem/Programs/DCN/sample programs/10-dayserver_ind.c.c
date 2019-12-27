//filename : dayserver_ind.c

#include "unp.h"
#include <time.h>

int tcp_listen(const char *host, const char *serv, socklen_t *addrlenp)
{
	int listenfd, n;
	const int on =1;
	struct addrinfo hints, *res, *ressave;

	bzero(&hints, sizeof(struct addrinfo));
	hints.ai_flags=AI_PASSIVE;	//since server program
	hints.ai_family=AF_UNSPEC; //could be IPv4 or IPv6
	hints.ai_socktype=SOCK_STREAM; //tcp 

	if((n=getaddrinfo(host, serv, &hints, &res))!=0)
	{
		printf("\ntcp_listen error for %s, %s: %s", host, 				serv, gai_strerror(n));  //respective error msg 						//will be returned by gai_strerro()
		exit(1);
	}
	ressave=res;	//back up res
	do
	{
		listenfd=socket(res->ai_family, res->ai_socktype, 						res->ai_protocol);
		if(listenfd<0)
			continue;	//error, try next one

		setsockopt(listenfd, SOL_SOCKET, SO_REUSEADDR, &on, 					sizeof(on));

		if(bind(listenfd, res->ai_addr, res->ai_addrlen)==0)
			break;	//success

		close(listenfd);	//bind error, try next one
	}while((res=res->ai_next)!=NULL);

	if(res==NULL)
		printf("\n tcp_listen error for %s, %s\n", host, serv);

	listen(listenfd, LISTENQ);
	if(addrlenp)
		*addrlenp = res->ai_addrlen;	//return size of 									//protocol address

	freeaddrinfo(ressave);	

	return(listenfd);
}


int main(int argc, char **argv)
{
	int listenfd, connfd;
	socklen_t addrlen, len;
	char str[MAXLINE];
	time_t ticks;
	struct sockaddr *cliaddr;

	if(argc!=2)
	{
		printf("\nUsage: program_name <service/port>\n");
		exit(1);
	}

	listenfd = tcp_listen(NULL, argv[1], &addrlen);
	//argv[1] is the name of the service or its port no

	cliaddr=malloc(addrlen);

	for(;;)
	{
		len=addrlen;
		connfd=accept(listenfd, cliaddr, &len);
		ticks=time(NULL);
		snprintf(str, sizeof(str), "%s\r\n", ctime(&ticks));
		write(connfd, str, strlen(str));
		close(connfd);
	}
}
