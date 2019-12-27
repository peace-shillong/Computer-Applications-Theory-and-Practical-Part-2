//filename: dayclient_ind.c

#include "unp.h"

int tcp_connect(const char *host, const char *serv)
{
	int sockfd, n;
	struct addrinfo hints, *res, *ressave;
	
	bzero(&hints, sizeof(struct addrinfo));
	hints.ai_family = AF_UNSPEC;
	hints.ai_socktype = SOCK_STREAM;
	
	if((n=getaddrinfo(host, serv, &hints, &res))!=0)
	{
		printf("\n tcp_conect error for %s, %s : %s\n", host, serv, gai_strerror(n));
		exit(1);
	}
	ressave = res;
	do
	{
		sockfd = socket(res->ai_family, res->ai_socktype, res->ai_protocol);
		if(sockfd<0)
			continue;	//ignore this one

		if(connect(sockfd, res->ai_addr, res->ai_addrlen)==0)
			break;	//success

		close (sockfd);
	}while((res = res->ai_next)!=NULL);

	if(res == NULL)
		printf("\n tcp_connect error for %s, %s", host, serv);

	freeaddrinfo(ressave);

	return (sockfd);
}


int main(int argc, char **argv)
{
	int sockfd, n;
	char str[MAXLINE+1];
	socklen_t len;
	struct sockaddr *sa;

	if(argc!=3)
	{
		printf("\nUsage: program <host/IP> <service/port>");
		exit(1);
	}
	sockfd=tcp_connect(argv[1], argv[2]);
	//argv[1] is host and argv[2] is service
	
	while((n=read(sockfd, str, MAXLINE))>0)
	{
		str[n]=0;
		fputs(str, stdout);
	}
	exit(0);
}
