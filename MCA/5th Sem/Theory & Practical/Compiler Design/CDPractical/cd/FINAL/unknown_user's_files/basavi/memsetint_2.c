#include<stdio.h>
#include<stdlib.h>
#include<string.h>
int main()
{
	int a;
	printf("\nenter the number\n");
	scanf("%d",&a);
	printf("\nthe integer value before memset() is=%d",a);
	memset(&a,0,sizeof(a));
	printf("the value after memset()=%d",a);
	exit(0);
}
