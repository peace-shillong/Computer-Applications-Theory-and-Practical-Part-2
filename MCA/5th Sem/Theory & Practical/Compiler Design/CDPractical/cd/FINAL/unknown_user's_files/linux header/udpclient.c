#include "unp.h"
void dg_cli(int sockfd,FILE *ptr,const struct sockaddr *pservaddr,socklen_t servlen)
{
	int n;
	char str[MAXLINE];
	while(fgets(str,MAXLINE,ptr)!=NULL)
	{
		sendto(sockfd,str,strlen(str),0,pservaddr,servlen);
		n=recvfrom(sockfd,str,MAXLINE,0,NULL,NULL);
		fputs(str,stdout);
	}
}
int main(int argc,char **argv)
{
	int sockfd;
	struct sockaddr_in servaddr;
	if(argc!=2)
	{
		printf("Usage :./client <IP address>");
		exit(1);
	}
	bzero(&servaddr,sizeof(servaddr));
	servaddr.sin_family=AF_INET;
	servaddr.sin_port=htons(1025);
	inet_pton(AF_INET,argv[1],&servaddr.sin_addr);
	sockfd=socket(AF_INET,SOCK_DGRAM,0);
	connect(sockfd,(struct sockaddr*)&servaddr,sizeof(servaddr));
	dg_cli(sockfd,stdin,(struct sockaddr*)&servaddr,sizeof(servaddr));
	exit(0);
}
