#include<iostream.h>
#include<conio.h>
#include<time.h>
#include<stdlib.h>
#include<math.h>
#include<stdio.h>
#define MAX 30000
long double mul(long double n , int x ,long double r )
 {
   if (x<2)
   {
       return n*r;
   }
   else if(x>=2)
   {
   long double p1,p2,p3,p4,a,b,c,d,p5;
   a=floor(n/(pow(10,x/2)));
   b=fmod(n,pow(10,x/2));
   c=floor(r/(pow(10,x/2)));
   d=fmod(r,pow(10,x/2));
   p1=mul(a,x/2,c);
   p2=mul(a,x/2,d);
   p3=mul(b,x/2,c);
   p4=mul(b,x/2,d);
   p5=p1*pow(10,x)+(p2+p3)*pow(10,x/2)+p4;
   return p5;
   }

}
 void  main()
{

 long double b,c;
 int n;
 clock_t t1,t2;
 clrscr();

 cout<<" ENTER THE NUMBER OF DIGITS YOU WANT :";
 cin>>n;
 t1=clock();
 if(n%2!=0)
 {
   cout<<"\n Enter a even number..";
   getch();
   exit(0);
 }
 cout<<"\n ENTER THE FIRST NUMBER :";
 cin>>b;
 cout<<"\n ENTER THE SECOND NUMBER :";
 cin>>c;

 long double a=mul(b,n,c);
 t2=clock();
 cout<<"\nTHE PRODUCT IS = "<<a;
 printf("\nThe time is = %.2f seconds",(t2-t1)/CLK_TCK);
 getch();
}
