// time taken by the mergesort

#include <windows.h>   
#include <stdio.h>  
#include <conio.h>  
#include <stdlib.h>   

#define SIZ 240000

void mergeSort(int arr[],int low,int mid,int high);
void partition(int arr[],int low,int high);
void AfterSort(int a[], int size);
void BeforeSort(int a[], int size);

int numbers[SIZ];

void main()
{
  int k;
  float te, ts;
  srand(GetTickCount()); 

  for (k = 0; k < SIZ; k++) 
		numbers[k] = rand();
	
  printf("\tMerge Sort Program\n");
  printf("\n\n");

  BeforeSort(numbers,SIZ);

  printf("\n\nNo of Elements           Time taken\n\n");
  
  for(long i=10000;i<=SIZ;)
  {
			ts=te=0;
			ts = GetTickCount();
  
			partition(numbers,0,i-1);
 
			te =  GetTickCount();
  

			AfterSort(numbers,SIZ);
			printf("%ld\t\t\t%.2f secs\n",i, (te - ts)/1000);

			switch(i){
				case 10000:
					i=20000;
					break;
				case 20000:
					i=30000;
					break;
				default:
					i+=30000;
			}
	}
	//getch();
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

    int i,m,k,l,temp[SIZ];

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