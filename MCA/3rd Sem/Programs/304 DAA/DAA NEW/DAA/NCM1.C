#include<stdio.h>
#include<conio.h>
#include<math.h>
#define M 100
long int Table[M][M];

void display(int ,int );
void combination(int ,int );
void initialize(int ,int );
void main()
{
	int n,m;
	clrscr();

	printf("Enter the value of n : ");
	scanf("%d",&n);
	printf("Enter the value of m : ");
	scanf("%d",&m);
	initialize(n,m);
 //	display(n,m);
	printf("\n\nTable after the Combination \n\n");
	combination(n,m);
	display(n,m);
	getch();
}
void display(int n,int m)
{
	int i,j;
	for(i=0;i<n;i++)
	{
		for(j=0;j<=m;j++)
		{
			printf("%ld\t",Table[i][j]);
		}
		printf("\n");
	}
	printf("Resultant combination is = %d",Table[n-1][m]);
}
void initialize(int n,int m)
{
	int i,j;
	for(i=0;i<n;i++)
		Table[i][0]=1;
	for(j=0;j<m;j++)
		if(j<2)
			Table[0][j]=1;
		else
			Table[0][j]=0;

}
void combination(int n,int m)
{
	int i,j;
	if(m<=n)
	{
		for(i=1;i<=n;i++)
		{
			for(j=1;j<=m;j++)
			{
				Table[i][j]=Table[i-1][j]+Table[i-1][j-1];
			}
		}
	}
}
