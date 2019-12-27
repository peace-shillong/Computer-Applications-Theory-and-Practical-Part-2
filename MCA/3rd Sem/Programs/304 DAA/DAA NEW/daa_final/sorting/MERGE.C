#include<conio.h>
#include<stdio.h>
#include<time.h>
#include<dos.h>
#include<stdlib.h>
#define size 60000
#define n_size 120000

void main()
{
 unsigned long a[size];
 unsigned long b[size];
 unsigned long c[size];
 unsigned long i,j,temp,k,n;
 time_t first, second;
 printf("\nMerge sort . . .");
 printf("\n Enter how many numbers: ");
 scanf("%d",&n);
 //randomize();
 printf("%d random numbers are generating..\n\n",n);
   for(i=0; i<n; i++)
   {
	a[i]=rand()%100000;
	b[i]=rand()%100000;	
   }
   printf("The first list is:");
	   for(i=0;i<n;i++)
			printf("\n%d",a[i]);
	printf("\nThe second list is:");
		for(i=0;i<n;i++)
			printf("\n%d",b[i]);
 printf("\n Number generated..\nSorting started.. just wait..");
 
 first = time(NULL);  /* Gets system time */
 for(i=0;i<size-1;i++)
 {
  for(j=i+1;j<size;j++)
    {
     if(a[i]>a[j])
     {
      temp=a[i];
      a[i]=a[j];
      a[j]=temp;
     }
     if(b[i]>b[j])
     {
      temp=b[i];
      b[i]=b[j];
      b[j]=temp;
     }
    }
 }
 for(i=j=k=0;i<n_size;)
  {
   if(a[j]<=b[k])
    c[i++]=a[j++];
   else
    c[i++]=b[k++];
   if(j==size || k==size)
    break;
  }
 for(;j<size;)
  c[i++]=a[j++];
 for(;k<size;)
  c[i++]=b[k++];
 second = time(NULL); /* Gets system time again */
 printf("\n The time is: %f seconds\n",difftime(second,first));
 
  getch();
}