#include	"unp.h"

void dg_client(FILE *fp, int sockfd, const struct sockaddr *pservaddr, socklen_t servlen)
{
        int n;
        char str[MAXLINE];

        while (fgets(str, MAXLINE, fp) != NULL) 
	  {

                sendto(sockfd, str, strlen(str), 0, pservaddr, servlen);	//do error trapping

                n = recvfrom(sockfd, str, MAXLINE, 0, NULL, NULL);		//do error trapping

                fputs(str, stdout);
        }
}

int main(int argc, char **argv)
{
	int sockfd;
	struct sockaddr_in servaddr;

	if (argc != 2)
	{
		printf("usage: udpcli <IPaddress>");
		exit(1);
	}

	bzero(&servaddr, sizeof(servaddr));
	servaddr.sin_family = AF_INET;
	servaddr.sin_port = htons(13456);
	inet_pton(AF_INET, argv[1], &servaddr.sin_addr);	//can do error trapping if IP is invalid

	sockfd = socket(AF_INET, SOCK_DGRAM, 0);	//can do error trapping if socket error

	dg_client(stdin, sockfd, (struct sockaddr *) &servaddr, sizeof(servaddr));

	exit(0);
}
