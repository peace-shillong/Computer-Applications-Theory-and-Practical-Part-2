//Program to find multiplication of two matrix//
#include<stdio.h>
#include<conio.h>
#include<windows.h>
void main()
{
	int a[10][10], b[10][10], c[10][10] ,i,j ,k, ro,co ,rs,cs ;
	long te, ts;
  srand(GetTickCount()); 

	
	printf("\n\t Enter the number of rows for first matrix : ");
	scanf("%d",&ro);
	printf("\n\t Enter the number of column for first matrix : ");
	scanf("%d",&co);

	for(i=0;i<ro;i++)
	{
	    for(j=0 ; j<co ; j++ )
	    {
		printf("\n\t Enter the numbers a[%d][%d] : " , i , j);
		scanf("%d",&a[i][j]);
	    }

	    printf("\n");
	}
	printf("\n\t The matrix of A :\n\n ");
	for(i=0 ; i<ro ; i++)
	{
	    for(j=0 ; j<co ;j++)
	    {
		printf("\t%2d",a[i][j]);

	    }
	    printf("\n");
	}
	printf("\n\t Enter the number of rows for second matrix : ");
	scanf("%d",&rs);
	printf("\n\t Enter the number of column for second matrix : ");
	scanf("%d",&cs);

	if(co==rs)
	{
		for(i=0;i<rs;i++)
		{
		    for(j=0 ; j<cs ; j++ )
		    {
			printf("\n\t Enter the numbers b[%d][%d] : " , i , j);
			scanf("%d",&b[i][j]);
			}
		    printf("\n");
		}
		printf("\n\t The matrix of B :\n\n ");
		for(i=0 ; i<rs ; i++)
			{
			 for(j=0 ; j<cs ;j++)
			{
			printf("\t%2d",b[i][j]);

			    }
		    printf("\n");
			}
		for(i=0 ; i<ro ; i++)
		{

		   for(j=0 ; j<co ;j++)
		   {
				ts=te=0;
				ts = GetTickCount();
			 c[i][j]=0;
			for(k=0;k<ro;k++)
			{
				c[i][j] +=a[i][k] * b[k][j];
			}
					te =  GetTickCount();
		    }
		}
	printf("\n\t The matrix multiplication:\n");
	for(i=0 ; i<ro ; i++)
	{
	    for(j=0 ; j<co ;j++)
	    {
		printf("\t%2d",c[i][j]);

	    }
	    printf("\n");
	}
	}
	else
		{
			printf("\nThe column of first matrix is not compatable with rows of second matrix...");
			}

		printf("\t\t\tTime : %ld secs\n", (te - ts)/1000);
	getch();

}