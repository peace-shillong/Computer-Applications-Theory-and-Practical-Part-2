#include <stdio.h>
#include <conio.h>
#include<time.h>
#include<stdlib.h>
void main()
{
	int a[100010];
	int i,j,temp,no,n,k;
	clock_t start,end;
	float ttt;
	n=0;
	//clrscr();
//	printf("\nENter the size of the array : ");
//	scanf("%d",&no);
	printf("\n\n\t PROGRAM TO FIND TIME COMPLEXITY OF BUBBLE SORT\n");
	printf("\n\nNumber of element\t\tTime(in seconds)\n");
	printf("******************************************\n");
	for(k=0;k<10;k++)
	{
		n=n+10000;

		for(i=0;i<n;i++)
			a[i]=rand()%50000;
		//printf("\nThe sorted elements of the list: ");
		start=clock();
		for(i=0;i<n-1;i++)
		{
			for(j=0;j<n-i-1;j++)
			{
				if(a[j]>a[j+1])
				{
					temp=a[j];
					a[j]=a[j+1];
					a[j+1]=temp;
				}
			}
		}
		end = clock();
		//for(i=0;i<n;i++)
		printf("\t%d ",n);
		ttt=(float)(end-start)/CLK_TCK;
		printf("\t\t\t%f",ttt);
		printf("\n");
	}
//	getch();
}

