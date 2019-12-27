#include"unp.h"
int main(int argc,char ** argv)
{
	int i,j;
	struct hostent *he;
	struct in_addr ** addr_list;
	if(argc!=2)
	{
		printf("usage: ./hostout<hostname>");
		exit(1);
	}
	if((he=gethostbyname(argv[1]))==NULL)
	{
		printf("\n unknown host");
		exit(1);
	}
	printf("\n hostdetails");
	printf("\n official name: %s\n",he->h_name);
	printf("ip address\n");
	addr_list=(struct in_addr **)he->h_addr_list;
	for(i=0;addr_list[i]!=NULL;i++)
	{
		printf("%s\n",inet_ntoa(*addr_list[i]));
		exit(0);
	}
}


