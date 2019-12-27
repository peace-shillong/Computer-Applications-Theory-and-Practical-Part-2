#include <windows.h>   
#include <stdio.h>  
#include <conio.h>  
#include <stdlib.h>  
#include<math.h>

int X[100],Y[100],n;
double result[200];

void input();
int multiply(int*,int*,int,int);

void main()
{
	int i,j;
	long te, ts;

	srand(GetTickCount()); 
	

	printf("\n\nEnter the number of digits :");
	scanf("%d",&n);

	
	printf("\n\nNumber read randomly is:::");
	input();

	printf("\n\n number obtained after multiplying:\n");
	 ts = GetTickCount();
	
	for(i=0;i<n;i++)
	{
		result[i] = multiply(X,Y,n,0);
		printf("%d",result[i]);
	}
	
	te =  GetTickCount();
	//printf("\n\nTime taken is %f",(te - ts)/100);
	
	getch();
}
void input()
{
	int i;
	
	for(i = 0;i<=n-1;i++)
	{
		X[i] = rand()%10;
		Y[i] = X[i];
	}
	
	printf("\n\n");
	
	for(i = 0; i<=n-1;i++)
	{
		printf("\n%d",X[i]);
	}
}
int multiply(int X[],int Y[],int n,int in)
{
	int i,A[100],B[100],C[100],D[100],T1,T2,T3,T4;
	i=0;
	
	if(n==1)
	{
		//printf("%d",X[in]*Y[in]);
		return(X[in]*Y[in]);
	}
	else
	{
		for(i=0;i<n/2;i++)
			A[i] = X[i];
	
		for(i =n/2;i<=n-1;i++)
			B[i] = X[i];
		
		for(i=0;i<n/2;i++)
			C[i] = Y[i];
		
		for(i =n/2;i<=n-1;i++)
			D[i] = Y[i];
		
		T1 = multiply(A,C,n/2,i);
		T2 = multiply(A,D,n/2,i);
		T3 = multiply(B,C,n/2,i);
		T4 = multiply(B,D,n/2,i);

		//printf("%d",T1*pow(10,n)*(T2+T3)*pow(10,n/2)+T4);
		return(T1*pow(10,n)*(T2+T3)*pow(10,n/2)+T4);
	}
}