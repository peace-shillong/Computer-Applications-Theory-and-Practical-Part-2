#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<alloc.h>
void create();
void display(struct node *p);
int n,size,t;
struct node
{
	int data;
	struct node *next;
}*start,*S=NULL;
void freeall(struct node *in)
{
	struct node *p,*q;
	struct node *next;
	p=in;
	while(p!=NULL)
	{
		q=p;
		p=p->next;
		free(q);
	}
}
struct node *getnode()
{
	struct node *p=NULL;
	p=(struct node *)malloc(sizeof(struct node));
	if(p==NULL)
	{
		printf("\n\n No more space");
		getch();
		exit(0);
	}
	return p;
}void bubblesort()
{
	struct node *p;
	struct node *q;
	int i,j,item;
	p=start;
	q=start->next;
	for(i=1;i<n-1;i++)
	{
		for(j=1;j<n-i;j++)
		{
			if(p->data>q->data)
			{
				item=p->data;
				p->data=q->data;
				p->data=item;
			}
			p=p->next;
			q=q->next;
		}
		p=start;
		q=p->next;
	}
}
void main()
{
	struct node *beg,*end;
	clrscr();
	printf("\n Reading the input");
	create();
	printf("\n Displaying");
	display(start);
	beg=end=start;
	while(end->next!=NULL)
	{
		end=end->next;
	}
	getch();
	mergesort(beg,end,n);
	display(S);
	printf("\n After Sorting");
	freeall(S);
	freeall(start);
	getch();
}
void create()
{
	struct node *p,*q;
	int i;
	printf("\n \n enter the no. of nodes:");
	scanf("%d",&n);
	p=getnode();
	p->data=random(30);
	p->next=NULL;
	start=q=p;
	for(i=1;i<n;i++)
	{
		p=getnode();
		p->data=random(30);
		p->next=NULL;
		q->next=p;
		q=p;
	}
}
void display(struct node *startpoint)
{
	struct node *p=startpoint;
	struct node *q;
	while(p!=NULL)
	{
		printf("%d-",p->data);
		p=p->next;
	}
	q=p;
}
