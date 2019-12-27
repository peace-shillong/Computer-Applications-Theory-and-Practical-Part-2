#include	"unp.h"


void str_cli(FILE *fp, int sockfd)
{
	char sendline[MAXLINE], recvline[MAXLINE];
	while (fgets(sendline, MAXLINE, fp) != NULL)
	{
		write(sockfd, sendline, strlen(sendline));
		if (read(sockfd, recvline, MAXLINE) == 0)
		{
			printf("str_cli : server terminated prematurely\n\n");
			exit(1);
		}
		fputs(recvline, stdout);
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
	servaddr.sin_port = htons(12352); //port no above 1024
	inet_pton(AF_INET, argv[1], &servaddr.sin_addr);

	connect(sockfd, (struct sockaddr *) &servaddr, sizeof(servaddr));

	str_cli(stdin, sockfd);		/* do it all */

	exit(0);
}
