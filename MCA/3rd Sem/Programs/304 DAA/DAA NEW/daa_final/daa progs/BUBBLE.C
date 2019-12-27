#include <stdio.h>
#include <conio.h>
#include <malloc.h>
#include <time.h>
struct node
{
	int data;
	struct node *next;
};
void display(struct node *a)
{
	while(a!=NULL)
	{
		printf("%d ",a->data);
		a=a->next;
	}
}
struct node* bubble(struct node *a)
{
	struct node *i,*j,*start;
	int temp;
	start=i=a;
	while(i!=NULL)
	{
		j=i;
		while(j!=NULL)
		{
			if(i->data>j->data)
			{
				temp=i->data;
				i->data=j->data;
				j->data=temp;
			}
			j=j->next;
		}
		i=i->next;
	}
	printf("\n");
	//display(a);
	return start;
}
struct node* create(struct node *a,long n)
{
	struct node *b,*start=NULL;
	long i=0;
	while(i<n)
	{
		a=(struct node*)malloc(sizeof(struct node));
		a->data=rand()%1000;
		a->next=NULL;
		if(start==NULL)
		{
			start=b=a;
		}
		else
		{
			b->next=a;
			b=a;
		}
		i++;
	}
	return start;
}
void main()
{
	struct node *a=NULL,*st;
	long i,n;
	clock_t start,end;
	clrscr();
	printf("\n\t\t SORTING PROGRAM USING BUBBLE SORT ALGORITHM \n");
	printf("\n\t\t ****************************************** \n");
	printf("\n\t\t Enter the no of elements of the array: ");
	scanf("%ld",&n);
	a=create(a,n);
	start=clock();
	st=bubble(a);
	display(st);
	end=clock();
	printf("\n\nTime Taken By BUBBLE SORT\ %.4f of %ld",(end-start)/CLK_TCK,n);
	getch();
}