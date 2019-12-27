#include<stdio.h>
#include<conio.h>
#include<stdlib.h>

void input(int[10][10],int n);
void display(int[10][10],int n);

int C[10][10];
int s = 0, t = 0;

int inverse(int A[10][10],int inv[10][10],int n)
{
	int i,j,m,p;
	int A11inv[10][10],A12inv[10][10],A21inv[10][10],A22inv[10][10];
	int A11[10][10],A12[10][10],A21[10][10],A22[10][10],delta[10][10],deltainv[10][10];
	int in1[10][10],in2[10][10],in3[10][10],in4[10][10],in5[10][10],in6[10][10],in7[10][10],in8[10][10];
	int c11[10][10],c12[10][10],c21[10][10],c22[10][10];

	if(n==1)
	{
		if(A[n-1][n-1]==0)
		{
			printf("\ncannot find inverse");
			getch();
			exit(0);
		}
	
		inv[s][t] = 1/A[n-1][n-1];
		s++;
		
		if(s==n)
		{
			s=0;
			t++;
		}
		
		return(1/A[n-1][n-1]);
	}
	else
	{
		for(i=0,m = 0;i<n/2;i++,m++)
		{
			for(j=0,p=0;j<n/2;j++,p++)
			{
				A11[m][p] = A[i][j];
			}
		}
		for(i=0,m=0;i<n/2;i++,m++)
		{
			for(j=n/2,p=0;j<n;j++,p++)
			{
				A12[m][p] = A[i][j];
			}
		}
		for(i=n/2,m=0;i<n;i++,m++)
		{
			for(j=0,p=0;j<n/2;j++,p++)
			{
				A21[m][p] = A[i][j];
			}
		}
		for(i=n/2,m=0;i<n;i++,m++)
		{
			for(j=n/2,p=0;j<n;j++,p++)
			{
				A22[m][p] = A[i][j];
			}
		}
	
		printf("\t%d",A11[0][0]);
		
		inverse(A11,A11inv,n/2);
		
		multiply(A21,A11inv,C,n/2);
		
		display(C,n/2);
		
		multiply(C,A12,C,n/2);
		
		display(C,n/2);
		
		subtract(A22,C,n/2,delta);
		
		for(i = 0 ; i<n/2;i++)
		{
			for(j = 0;j<n/2;j++)
			{
				inv[i][j] = in3[i][j];
			}
		} 
		
		inverse(delta,deltainv,n/2);
		
		multiply(A11inv,A12,C,n/2);
		
		display(C,n/2);
		
		multiply(C,deltainv,C,n/2);
		
		display(C,n/2);
		
		multiply(C,A21,C,n/2);
		
		display(C,n/2);
		
		multiply(C,A11inv,C,n/2);
		display(C,n/2);
		
		add(C,A11inv,n/2,c11);

		inv[s][t] = c11[0][0];
		
		s++;
		
		if(s==n)
		{
			s=0;
			t++;
		}

		multiply(A11inv,A12,C,n/2);
		display(C,n/2);
		
		multiply(C,deltainv,c12,n/2);
		display(C,n/2);

		inv[s][t] = c12[0][0];
		s++;
		if(s==n)
		{
			s=0;
			t++;
		}

		multiply(deltainv,A21,C,n/2);
		display(C,n/2);
		
		multiply(C,A11inv,c21,n/2);
		display(C,n/2);
		
		inv[s][t] = c21[0][0];
		s++;
		
		if(s==n)
		{
			s=0;
			t++;
		}

		//0-in
		c22[0][0] = deltainv[0][0];
		
		inv[s][t] = c22[0][0];
		s++;
		
		if(s==n)
		{
			s=0;
			t++;
		}
	}
	//return 0;
}
int multiply(int A[10][10],int B[10][10],int c[10][10],int n)
{
	int i,j,s = 0,t = 0,m,p;

	int A11[10][10],A12[10][10],A21[10][10],A22[10][10];
	
	int B11[10][10],B12[10][10],B21[10][10],B22[10][10];
	
	int m1[10][10],m2[10][10],m3[10][10],m4[10][10],m5[10][10],m6[10][10],m7[10][10];
	
	int in1[10][10],in2[10][10],in3[10][10],in4[10][10],in5[10][10],in6[10][10],in7[10][10],in8[10][10],in9[10][10],in10[10][10],in11[10][10],in12[10][10],in13[10][10],in14[10][10];
	
	int c11[10][10],c12[10][10],c21[10][10],c22[10][10];

	if(n==1)
	{
		c[n-1][n-1] = A[n-1][n-1]*B[n-1][n-1];
		return (c[n-1][n-1]);
	}
	else
	{
		//for dividing A and B
		for(i=0,m = 0;i<n/2;i++,m++)
		{
			for(j=0,p=0;j<n/2;j++,p++)
			{
				A11[m][p] = A[i][j];
			}
		}
		for(i=0,m=0;i<n/2;i++,m++)
		{
			for(j=n/2,p=0;j<n;j++,p++)
			{
				A12[m][p] = A[i][j];
			}
		}
		for(i=n/2,m=0;i<n;i++,m++)
		{
			for(j=0,p=0;j<n/2;j++,p++)
			{
				A21[m][p] = A[i][j];
			}
		}
		for(i=n/2,m=0;i<n;i++,m++)
		{
			for(j=n/2,p=0;j<n;j++,p++)
			{
				A22[m][p] = A[i][j];
			}
		}
		for(i=0,m = 0;i<n/2;i++,m++)
		{
			for(j=0,p=0;j<n/2;j++,p++)
			{
				 B11[m][p] = B[i][j];
			}
		}
		for(i=0,m=0;i<n/2;i++,m++)
		{
			for(j=n/2,p=0;j<n;j++,p++)
			{
				B12[m][p] = B[i][j];
			}
		}
		for(i=n/2,m=0;i<n;i++,m++)
		{
			for(j=0,p=0;j<n/2;j++,p++)
			{
				B21[m][p] = B[i][j];
			}
		}
		for(i=n/2,m=0;i<n;i++,m++)
		{
			for(j=n/2,p=0;j<n;j++,p++)
			{
				 B22[m][p] = B[i][j];
			}
		}

		//for caculating m1,m2,m3.....
		subtract(A12,A22,n/2,in5);
		add(B21,B22,n/2,in6);
		multiply(in5,in6,m1,n/2);

		add(A11,A22,n/2,in7);
		add(B11,B22,n/2,in8);
		multiply(in7,in8,m2,n/2);

		subtract(A11,A21,n/2,in9);
		add(B11,B12,n/2,in10);
		multiply(in9,in10,m3,n/2);

		add(A11,A12,n/2,in11);
		multiply(in11,B22,m4,n/2);

		subtract(B12,B22,n/2,in12);
		multiply(A11,in12,m5,n/2);

		subtract(B21,B11,n/2,in13);
		multiply(A22,in13,m6,n/2);

		add(A21,A22,n/2,in14);
		multiply(in14,B11,m7,n/2);

		add(m1,m2,n/2,in1);
		add(m4,m6,n/2,in2);
		subtract(in1,in2,n/2,c11);

		for(i=0;i<n/2;i++)
		{
			for(j=0;j<n/2;j++)
			{
				C[t][s] = c11[i][j];
				printf("%d",c11[i][j]);

				s++;
				if(s==n)
				{
					s=0;
					t++;
				}
			}
		}

		add(m4,m5,n/2,c12);
		printf("%d",c12[0][0]);
		C[t][s] = c12[0][0];
		s++;
		if(s==n)
		{
			s=0;
			t++;
		}

		add(m6,m7,n/2,c21);
		printf("%d",c21[0][0]);

		C[t][s] = c21[0][0];
		s++;
		if(s==n)
		{
			s=0;
			t++;
		}

		subtract(m2,m3,n/2,in3);
		subtract(m5,m7,n/2,in4);
		add(in3,in4,n/2,c22);
		printf("%d",c22[0][0]);

		C[t][s] = c22[0][0];
		s++;
		if(s==n)
		{
			s=0;
			t++;
		}
		//printf("%d",C[s][t]);

	}
	return 0.0;
}

void display(int X[10][10],int n)
{
	int i,j;
	printf("\n");
	for(i = 0;i<n;i++)
	{
		printf("\n");
		for(j = 0;j<n;j++)
		{
			printf("\t%d",X[i][j]);
		}
       }
}
void input(int X[10][10],int n)
{
	int i,j;
	printf("\n");
	for(i = 0;i<n;i++)
	{
		for(j = 0;j<n;j++)
		{
			scanf("%d",&X[i][j]);
		}
	}
}
int add(int X[10][10],int Y[10][10],int n,int d[10][10])
{
	int i,j;
	for(i=0;i<n;i++)
	{
		for(j = 0;j<n;j++)
		{
			d[i][j] = X[i][j]+Y[i][j];
		}
	}
	return;
}
int subtract(int X[10][10],int Y[10][10],int n,int d[10][10])
{
	int i,j;
	for(i=0;i<n;i++)
	{
		for(j = 0 ;j < n ; j++)
		{
			d[i][j] = X[i][j]-Y[i][j];
		}
	}
       return;
}
void main()
{
	int n;
	int A[10][10],Ainv[10][10];
	//clrscr();
	printf("\nEnter the  size of the matrix:");
	scanf("%d",&n);
	printf("\nenter the matrix elements:");
	input(A,n);
	printf("\n%d",A[0][0]);
	inverse(A,Ainv,n);
	printf("\nMatrix obtained after inverse");
	display(Ainv,n);
	getch();
}
