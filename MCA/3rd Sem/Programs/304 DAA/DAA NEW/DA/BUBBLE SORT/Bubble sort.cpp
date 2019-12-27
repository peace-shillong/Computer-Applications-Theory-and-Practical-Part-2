// time taken by the bubblesort

#include <windows.h>   
#include <stdio.h> 
#include <conio.h>    
#include <stdlib.h>   

#define ITEMS 100000

void Bubblesort(int arr[],int size);
void AfterSort(int a[], int size);
void BeforeSort(int a[], int size);

int numbers[ITEMS];

void main()
{
  int k;
  long te, ts;
  srand(GetTickCount()); 
	
  printf("\n\n\t**********BUBBLE SORT TIME COMPPLEXITY************");

  for (k = 0; k < ITEMS; k++) 
    numbers[k] = rand();

  BeforeSort(numbers,ITEMS);
  ts = GetTickCount();
  
  Bubblesort(numbers,ITEMS);
 
  te =  GetTickCount();

  AfterSort(numbers,ITEMS);
  printf("The time taken by BUBBLE SORT is----> %d secs\n", (te - ts)/1000);
  
  getch();
}



void Bubblesort(int arr[],int size)
{

    int i,j,temp;
	
    for(i=0;i<size-1;i++)
	{
		for(j=0;j<size-i-1;j++)
		 {
             if (arr[j] > arr[j+1])
			 {
	
				temp=arr[j];
				arr[j]=arr[j+1];
				arr[j+1]=temp;
	         }
		}
    }
   
}

void AfterSort(int a[], int size)
{
	FILE *fp;
	fp=fopen("AfterSort.txt","w");
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
	fp=fopen("BeforeSort.txt","w");
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