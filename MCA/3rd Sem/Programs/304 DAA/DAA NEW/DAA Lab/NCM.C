// Dynamic Programming for nCm
#include<stdio.h>
#include<conio.h>

long int table[100][100];
long int combination(int n,int m)
{
	if(n==m || m==0)
		table[n][m]=1;
	else
		if(m>0 && m<n)
			table[n][m]=combination(n-1,m)+combination(n-1,m-1);
	return table[n][m];
}

void main()
{
	int n, m;
	int i,j;
	int error;
	clrscr();
	printf("\n                   Dynamic programming (nCm)   ");
	do
	{
		error=0;
		printf("\n\tEnter n : ");
		scanf("%d",&n);
		printf("\n\tEnter m : ");
		scanf("%d",&m);
		if(m>n)
		{
			clrscr();
			printf("\n\tError !!! Since m>n\n");
			error=1;
		}
	}while(error==1);
	table[n][m]=combination(n,m);
	printf("\n\tTable After Combination\n");
	for(i=0;i<=n;i++)
	{
		printf("\n\t");
		for(j=0;j<=m;j++)
		{
			if(j>i)
				printf("-\t");
			else
			{
				table[i][j]=combination(i,j);
				printf("%d\t",table[i][j]);
			}
		}
	}
	printf("\n\tThe Resultant = %ld",table[n-1][m]);
	getch();
}