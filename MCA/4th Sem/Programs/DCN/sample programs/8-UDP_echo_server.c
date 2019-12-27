#include "unp.h"

void dg_server(int sockfd, struct sockaddr *pcliaddr, socklen_t clilen)
{
        int n;
        socklen_t len;
        char str[MAXLINE];

        for (;;) 
	  {
                len = clilen;
                n = recvfrom(sockfd, str, MAXLINE, 0, pcliaddr, &len);	//error trapping

                sendto(sockfd, str, n, 0, pcliaddr, len);
        }
}

int main(int argc, char **argv)
{
	int sockfd;
	struct sockaddr_in servaddr, cliaddr;

	sockfd = socket(AF_INET, SOCK_DGRAM, 0);	//error trapping for socket creation error

	bzero(&servaddr, sizeof(servaddr));
	servaddr.sin_family      = AF_INET;
	servaddr.sin_addr.s_addr = htonl(INADDR_ANY);
	servaddr.sin_port        = htons(13456);

	bind(sockfd, (struct sockaddr *) &servaddr, sizeof(servaddr));	//do error trapping 

	dg_server(sockfd, (struct sockaddr *) &cliaddr, sizeof(cliaddr));
}
