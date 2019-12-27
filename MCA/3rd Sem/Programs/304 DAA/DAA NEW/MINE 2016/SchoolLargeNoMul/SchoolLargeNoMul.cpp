//Program For Multiplying Large Numbers Using School Method

#include<stdio.h>
#include<conio.h>
#include<math.h>
#include<stdlib.h>
#include<string.h>
#include<time.h>
#define MAX 5000

char * multiply(char [],char[]);
void main()
{
    char a[MAX];
    char b[MAX];
    clock_t beg,end;
    char *c;
    int la,lb;
    int i;
    
    beg=clock();
    printf("\nLarge number multiplication\n\n");
    printf("Enter the first number : ");
    scanf("%s",a);
    printf("Enter the second number : ");
    scanf("%s",b);
    printf("\nMultiplication of two numbers : ");
    c = multiply(a,b);
    end=clock();
    printf("%s",c);
    printf("\n\nTime taken is %0.4f msecs",difftime(end,beg)/100);
    getch();
}

char * multiply(char a[],char b[])
{
    static char mul[MAX];
    char c[MAX];
    char temp[MAX];
    int la,lb;
    int i,j,k=0,x=0,y;
    long int r=0;
    long sum = 0;
    la=strlen(a)-1;
        lb=strlen(b)-1;
   
        for(i=0;i<=la;i++){
                a[i] = a[i] - 48;
        }

        for(i=0;i<=lb;i++){
                b[i] = b[i] - 48;
        }

    for(i=lb;i>=0;i--){
         r=0;
         for(j=la;j>=0;j--){
             temp[k++] = (b[i]*a[j] + r)%10;
             r = (b[i]*a[j]+r)/10;
         }
         temp[k++] = r;
         x++;
         for(y = 0;y<x;y++){
             temp[k++] = 0;
         }
    }
   
    k=0;
    r=0;
    for(i=0;i<la+lb+2;i++){
         sum =0;
         y=0;
         for(j=1;j<=lb+1;j++){
             if(i <= la+j){
                 sum = sum + temp[y+i];
             }
             y += j + la + 1;
         }
         c[k++] = (sum+r) %10;
         r = (sum+r)/10;
    }
    c[k] = r;
    j=0;
    for(i=k-1;i>=0;i--){
         mul[j++]=c[i] + 48;
    }
    mul[j]='\0';
    return mul;
}