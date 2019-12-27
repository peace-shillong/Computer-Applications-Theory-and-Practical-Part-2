#include	"unp.h"
#define MAXLINE 100

//usage of shutdown() and select()



void echo_client(FILE *fp, int sockfd)
{
	int maxfdp1, stdineof;
	fd_set rset;
	char str[MAXLINE];
	int n;

	stdineof = 0;
	FD_ZERO(&rset);

	for(;;)
	{
		if(stdineof == 0)
			FD_SET(fileno(fp), &rset);

		FD_SET(sockfd, &rset);
		maxfdp1 = max(fileno(fp), sockfd) + 1;

		select(maxfdp1, &rset, NULL, NULL, NULL);

		if(FD_ISSET(sockfd, &rset))  //socket is readable
		{
			if ((n=read(sockfd, str, MAXLINE)) == 0)
			{
				if(stdineof == 1)
					return;	//normal termination
				else
				{
					printf("Server terminated prematurely\n\n");
					exit(1);
				}
			}
			write(fileno(stdout), str, n);
		}

		if(FD_ISSET(fileno(fp), &rset))  //input is readable
		{
			if((n=read(fileno(fp),str,MAXLINE))==0)
			{
				stdineof = 1;
				shutdown(sockfd, SHUT_WR);	//send FIN
				FD_CLR(fileno(fp), &rset);
				continue;
			}
			write(sockfd, str, n);
		}
	}
}
int main(int argc, char **argv)
{
	int sockfd;
	struct sockaddr_in servaddr;

	if (argc != 2)
	{
		printf("usage: tcpcli <IPaddress>");
		exit(1);
	}
	sockfd = socket(AF_INET, SOCK_STREAM, 0);

	bzero(&servaddr, sizeof(servaddr));
	servaddr.sin_family = AF_INET;
	servaddr.sin_port = htons(12353);
	inet_pton(AF_INET, argv[1], &servaddr.sin_addr);

	connect(sockfd, (struct sockaddr *) &servaddr, sizeof(servaddr));

	echo_client(stdin, sockfd);		/* do it all */

	exit(0);
}
