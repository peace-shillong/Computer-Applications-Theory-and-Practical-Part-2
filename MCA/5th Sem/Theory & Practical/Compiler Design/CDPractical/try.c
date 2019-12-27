#include <stdio.h>
#include <conio.h>

void main()
{
	int a,i,fact;
	printf("enter the value of a: ");
	scanf("%d",&a);
	if(a>0)
	{
		fact=1;
		for(i=1;i<=a;i++)
		{
			fact=fact*i;
		}
		printf("the factorial of n is %d",fact);
	}
	else
		printf("cannot calculate factorial as number is < 0");
	getch();	
	return;
}