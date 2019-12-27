// time taken by the bubblesort

#include <windows.h>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

#define SIZE 300000

void Bubblesort(int arr[],int size);
void AfterSort(int a[], int size);
void BeforeSort(int a[], int size);

int numbers[SIZE];

void main()
{
  int k;
  float te, ts;
  srand(GetTickCount()); 

  for (k = 0; k < SIZE; k++) 
		numbers[k] = rand();

  printf("\tBubble Sort Program\n");

  BeforeSort(numbers,SIZE);
  printf(" No of Elements		Time taken\n\n");
    
  for(long i=10000;i<=SIZE;)
  {
			ts=te=0;
			ts = GetTickCount();
		  
			Bubblesort(numbers,i);
		 
			te =  GetTickCount();
  

			AfterSort(numbers,SIZE);
			printf(" %ld\t\t\t%.2f secs\n",i, (te - ts)/1000);
			switch(i){
				case 10000:
					i=120000;
					break;
				case 120000:
					i=210000;
					break;
				default:
					i+=30000;
			}
  }
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