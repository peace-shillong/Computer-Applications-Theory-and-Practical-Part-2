#include <time.h>
#include <stdio.h>
#include <dos.h>
#include <conio.h>
#include <stdlib.h>

void main()
{
   unsigned long aa[120000],z[120000];
   unsigned long i,j,temp,n;
   time_t first, second;

   printf("\n Enter how many numbers: ");
   scanf("%d",&n);

   printf("%d random numbers are: \n\n",n);
   for(i=0; i<n; i++)
   {
       z[i]=rand()%100000;
       printf("%d\n",z[i]); //random(1000) /*% 100*/);
     aa[i]=z[i];
   }

   first = time(NULL);  /* Gets system time */
   for(i=0;i<n-1;i++)
   for(j=0;j<n-i-1;j++)
   if(aa[j]>aa[j+1])
   {
     temp=aa[j];
     aa[j]=aa[j+1];
     aa[j+1]=temp;
   }
   second = time(NULL); /* Gets system time again */
   printf("\n After sorting: \n");
   for(i=0;i<n;i++)
     printf("\t %d",aa[i]);
   printf("\n The time is: %f seconds\n",difftime(second,first));
   getch();
}