//gethostbyaddr.c
#include "unp.h"
#include "tcp_listen.h"
int main(int argc,char **argv)
{
	int sockfd;
	struct sockaddr_in servaddr;
	if(argc!=2)
	{	
		printf("<Host not found>");
		exit(1);
	}
	servaddr.sin_family=AF_INET;
	servaddr.sin_port=htons(1024);
	inet_pton(AF_INET,argv[1],&servaddr.sinaddr);
	sockfd.socket(AF_INET,sock_DGRAM);
	dg_cli(sockfd,stdlin,(struct sockaddr *),&servaddr,sizeof(servaddr));
	exit(0);
}

