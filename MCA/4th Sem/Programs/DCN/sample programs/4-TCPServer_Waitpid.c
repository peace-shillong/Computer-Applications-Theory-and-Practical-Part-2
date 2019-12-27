//using waitpid()
//server program

#include "unp.h"

void server_echo(int sockfd)
{
	int n;
	char str[MAXLINE];
	for (;;)
	{
		if ((n=read(sockfd, str, 100)) == 0 )
			return;		//connection closed by other end
		write(sockfd, str, n);
	}
}

void sig_chld(int signo)
{
	pid_t pid;
	int stat;

	while((pid = waitpid(-1, &stat, WNOHANG))>0)
		printf("\n\n child %d terminated\n\n", pid);
	return;
}

int main(int argc, char **argv)
{
	int listenfd, connfd;
	pid_t childpid;
	socklen_t clilen;
	struct sockaddr_in cliaddr, servaddr;
	void sig_chld(int);

	listenfd = socket(AF_INET, SOCK_STREAM, 0);

	bzero(&servaddr, sizeof(servaddr));

	servaddr.sin_family      = AF_INET;
	servaddr.sin_addr.s_addr = htonl(INADDR_ANY);
	servaddr.sin_port        = htons(12351);

	bind(listenfd, (struct sockaddr *) &servaddr, sizeof(servaddr));

	listen(listenfd, LISTENQ);

	signal(SIGCHLD, sig_chld);	//must call wait() or waitpid()

	for ( ; ; ) 
	{
		clilen = sizeof(cliaddr);
		if((connfd = accept(listenfd, (struct sockaddr *) &cliaddr, &clilen))<0)
		{
			if (errno == EINTR)
				continue;	//back to for()
			else
			{
				printf("\n\n accept() error\n");
				exit(1);			
			}
		}
		if ( (childpid = fork()) == 0) 
		{	/* child process */
			close(listenfd);	/* close listening socket */
			str_echo(connfd);	/* process the request */
			exit(0);
		}
		close(connfd);			/* parent closes connected socket */
	}
}
