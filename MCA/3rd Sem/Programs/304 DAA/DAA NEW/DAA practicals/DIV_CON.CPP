#include<iostream.h>
#include<conio.h>
#include<stdlib.h>
#include<math.h>
#include<time.h>
#include<stdio.h>
#define MAX 30000
long double mul(long double n , int x ,long double r )
{
	if (x<2)
	{
		return n*r;
	}
	else if(x>=2)
	{
		long double p1,p2,p3,p4,a,b,c,d,p5;
		a=floor(n/(pow(10,x/2)));
		b=fmod(n,pow(10,x/2));
		c=floor(r/(pow(10,x/2)));
		d=fmod(r,pow(10,x/2));
		p1=mul(a,x/2,c);
		p2=mul(a,x/2,d);
		p3=mul(b,x/2,c);
		p4=mul(b,x/2,d);
		p5=p1*pow(10,x)+(p2+p3)*pow(10,x/2)+p4;
		return p5;
	}
	return 1;
}
void  main()
{
	long double a,b,c;
	int n;
	clock_t beg,end,time;
	clrscr();
	cout<<"\n\tDIVIDE AND CONQUER ALGORITHM\n";
	cout<<" Enter the number of digits:";
	cin>>n;
	beg=clock();
	cout<<"\n ENTER THE FIRST NUMBER :";
	cin>>b;
	cout<<"\n ENTER THE SECOND NUMBER :";
	cin>>c;
	a=mul(b,n,c);
	end=clock();
	difftime(end,beg);
	cout<<"\n THE PRODUCT IS = "<<a;
	printf("\nThe total time taken is %0.2f msec",difftime(end,beg));
	getch();
}
