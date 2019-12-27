#include<stdio.h>
#include<conio.h>
#include<time.h>
#include<stdlib.h>
#define MAX 100000
void merge(int arr[],int lower,int mid,int upper)
{
	int aux[MAX],i,j,k=0;
	i=lower;
	j=mid;
	while(i<mid && j<=upper)
	{
		if(arr[i]<arr[j])
			aux[k++]=arr[i++];
		else
			aux[k++]=arr[j++];
	}
	while(i<mid)
		aux[k++]=arr[i++];
	while(j<=upper)
		aux[k++]=arr[j++];
	for(i=lower,k=0;i<=upper;i++,k++)
		arr[i]=aux[k];
}
void mergesort(int arr[],int lower,int upper)
{
	int mid;
	if(upper>lower)
	{
		mid=(upper+lower)/2;
		mergesort(arr,lower,mid);
		mergesort(arr,mid+1,upper);
		merge(arr,lower,mid+1,upper);
	}
}
void main()
{
	int a[100000];
	int i,n,no,k;
	clock_t start,end;
	float ttt;
	//clrscr();
	//printf("\nEnter the size of the array : ");
	//scanf("%d",&no);
	printf("\n\n\t PROGRAM TO FIND TIME COMPLEXITY OF MERGE SORT\n");
	n=0;
	printf("\n\nNumber of element\t\tTime(in seconds)\n");
	printf("******************************************\n");
	for(k=0;k<10;k++)
	{
		n=n+10000;
		for(i=0;i<n;i++)
			a[i]=rand()%100000;
		//printf("\nThe sorted elements of the list: ");
		start=clock();
		mergesort(a,0,n-1);
		end=clock();
		ttt=(float)(end-start)/CLK_TCK;
		//for(i=0;i<n;i++)
		printf(" \t%d ",n);
		printf("\t\t\t%f",ttt);
		printf("\n");
	}
	//getch();
}

