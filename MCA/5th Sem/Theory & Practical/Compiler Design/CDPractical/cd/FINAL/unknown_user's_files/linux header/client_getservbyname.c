#include "unp.h"
int main(int argc, char **argv)
{
	int n,sockfd;
	char str[MAXLINE];
	struct sockaddr_in servaddr;
	struct in_addr **pptr;
	struct in_addr *inetaddrp[2];
	struct in_addr inetaddr;
	struct hostent *hp;
	struct servent *sp;

	if(argc !=3)
	{
		printf("\n Usage :./client <hostname> <servicename>");
		exit(1);
	}
	if((hp=gethostbyname(argv[1]))==NULL)
	{
		if(inet_aton(argv[1],&inetaddr)==0)
		{
			printf("\nHostname error for %s %s \n",argv[1],argv[2]);
			exit(1);
		}
		else
		{
			inetaddrp[0]=&inetaddr;
			inetaddrp[1]=NULL;
			pptr=inetaddrp;
		}
	}
	else
		pptr=(struct in_addr**)hp->h_addr_list;
	if((sp=getservbyname(argv[2],"tcp"))==NULL)
	{
		printf("\nDervice name is unknown");
		exit(1);
	}
	for(;*pptr!=NULL;pptr++)
	{
		sockfd=socket(AF_INET,SOCK_STREAM,0);
		bzero(&servaddr,sizeof(servaddr));
		servaddr.sin_family=AF_INET;
		servaddr.sin_port=sp->s_port;
		memcpy(&servaddr.sin_addr,*pptr,sizeof(struct in_addr));
		if(connect(sockfd,(struct sockaddr *)&servaddr,sizeof(servaddr))==0)
			break;
		printf("Connection Error\n");
		close(sockfd);
	}
	if(*pptr==NULL)
	{
		printf("\nUnable to connect");
		exit(1);
	}
	while(n=read(sockfd,str,MAXLINE)>0)
		fputs(str,stdout);
	exit(0);

}
