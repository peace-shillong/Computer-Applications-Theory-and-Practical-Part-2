#include<stdio.h>
#include<stdlib.h>
#include<arpa/inet.h>
int main(int argc,char **argv)
{
	struct in_addr ip;
	if(argc!=2)
	{
		printf("usage<command><ip address>");
		exit(1);
	}
	if(inet_aton(argv[1],&ip)==0)
	{
		printf("invalid address");
	}
	printf("The ipv4 address entered is valid");
	printf("%s",inet_ntoa(ip));
	exit(0);
}

