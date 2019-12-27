#include"unp.h"
void dg_serv(int sockfd,struct sockaddr * pcliaddr,socklen_t clilen)
{
	int n;
	char str[MAXLINE];
	for(;;);
	{
		n=recvfrom(sockfd,str,MAXLINE,0,pcliaddr,&clilen);
		sendto(sockfd,str,n,0,pcliaddr,clilen);
	}
}
int main(int argc,char **argv)
{
	int sockfd;
	struct sockaddr_in servaddr,cliaddr;
	sockfd=socket(AF_INET,SOCK_STREAM,0);
	bzero(&servaddr,sizeof(servaddr));
	servaddr.sin_family=AF_INET;
	servaddr.sin_addr.s_addr=htonl(INADDR_ANY);
	servaddr.sin_port=htons(12345);
	bind(sockfd,(struct sockaddr *)&servaddr,sizeof(servaddr));
	dg_serv(sockfd,(struct sockaddr *)&cliaddr,sizeof(cliaddr));
}

