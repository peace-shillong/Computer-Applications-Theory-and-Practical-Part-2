// merge_sort

#include <windows.h>   
#include <stdio.h>  
#include <conio.h>  
#include <stdlib.h>   

#define ITEMS 500000

void mergeSort(int arr[],int low,int mid,int high);
void partition(int arr[],int low,int high);
void AfterSort(int a[], int size);
void BeforeSort(int a[], int size);

int numbers[ITEMS];

void main()
{
  int k;
  long te, ts;

  srand(GetTickCount()); 

  for (k = 0; k < ITEMS; k++) 
    numbers[k] = rand();

  BeforeSort(numbers,ITEMS);
  ts = GetTickCount();
  
  partition(numbers,0,ITEMS-1);
 
  te =  GetTickCount();

  AfterSort(numbers,ITEMS);
  printf("The time taken by MERGE SORT is----> %d secs\n", (te - ts)/1000);
  
  getch();
}


void partition(int arr[],int low,int high)
{

    int mid;

    if(low<high)
	{
         mid=(low+high)/2;
         partition(arr,low,mid);
         partition(arr,mid+1,high);
         mergeSort(arr,low,mid,high);
    }
}

void mergeSort(int arr[],int low,int mid,int high)
{

    int i,m,k,l,temp[ITEMS];

    l=low;
    i=low;
    m=mid+1;

    while((l<=mid)&&(m<=high))
	{
         if(arr[l]<=arr[m])
		 {
             temp[i]=arr[l];
             l++;
         }
         else
		 {
             temp[i]=arr[m];
             m++;
         }
         i++;
    }

    if(l>mid)
	{
         for(k=m;k<=high;k++)
		 {
             temp[i]=arr[k];
             i++;
         }
    }
    else
	{
         for(k=l;k<=mid;k++)
		 {
             temp[i]=arr[k];
             i++;
         }
    }
   
    for(k=low;k<=high;k++)
	{
         arr[k]=temp[k];
    }
}

void AfterSort(int a[], int size)
{
	FILE *fp;
	fp=fopen("ASort.txt","w");
	if (fp==NULL)
	{
		printf("\nCannot Open File");
		exit(1);
	}
	for(int i=0;i<size;i++)
	{
		fprintf(fp,"  %d",a[i]);
	}
	fclose(fp);
}

void BeforeSort(int a[], int size)
{
	FILE *fp;
	fp=fopen("BSort.txt","w");
	if (fp==NULL)
	{
		printf("\nCannot Open File");
		exit(1);
	}
	for(int i=0;i<size;i++)
	{
		fprintf(fp,"  %d",a[i]);
	}
	fclose(fp);
}