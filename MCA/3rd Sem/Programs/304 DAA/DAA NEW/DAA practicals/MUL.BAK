
#include<iostream.h>
#include<stdlib.h>
#include<conio.h>
#include<string.h>
#define M 200
struct Mul_Num
{
	int arr[M];
	int size;
};

void split(Mul_Num &A,Mul_Num &B,const Mul_Num &X);
Mul_Num raised(Mul_Num num1,int rvalue);
Mul_Num adder(const Mul_Num &num1,const Mul_Num &num2);

Mul_Num multiply(Mul_Num X,Mul_Num Y)
{
	Mul_Num A,B,C,D,temp;
	Mul_Num t1,t2,t3,t4;
	int value,i=0;

	if(X.size==1)
	{
		value=X.arr[0]*Y.arr[0];
		if(value>9)
		{
			temp.size=2;
			while(value>0)
			{
				temp.arr[i++]=value % 10;
				value/=10;
			}
		}
		else
		{
			temp.size=1;
			temp.arr[0]=value;
		}
		return temp;
	}
	else
	{
		split(A,B,X);
		split(C,D,Y);

		t1=raised(multiply(A,C),X.size);
		t2=raised(multiply(A,D),(X.size)/2);
		t3=raised(multiply(B,C),(X.size)/2);
		t4=multiply(B,D);

		return adder(adder(t1,t2),adder(t3,t4));
	}
}
Mul_Num adder(const Mul_Num &num1,const Mul_Num &num2)
{
	int i,j,k,carry;
	Mul_Num temp;

	i=j=k=carry=0;
	while(i<num1.size && j<num2.size)
	{
		if((num1.arr[i]+num2.arr[j]+carry) > 9)
		{
			temp.arr[k]=(num1.arr[i]+num2.arr[j]+carry) % 10;
			carry=1;
		}
		else
		{
			temp.arr[k]=num1.arr[i]+num2.arr[j]+carry;
			carry=0;
		}
		i++; j++; k++;
	}
	while(i<num1.size)
	{
		if((num1.arr[i]+carry)>9)
		{
			temp.arr[k]=(num1.arr[i]+carry)%10;
			carry=1;
		}
		else
		{
			temp.arr[k]=num1.arr[i]+carry;
			carry=0;
		}
		i++; k++;
	}
	while(j<num2.size)
	{
		if((num2.arr[j]+carry)>9)
		{
			temp.arr[k]=(num2.arr[j]+carry)%10;
			carry=1;
		}
		else
		{
			temp.arr[k]=num2.arr[j]+carry;
			carry=0;
		}
		j++; k++;
	}
	if(carry)
		temp.arr[k++]=carry;
	temp.size=k;
	return temp;
}
Mul_Num raised(Mul_Num num1,int rvalue)
{
	int i,j;

	i=num1.size+rvalue-1;
	j=num1.size-1;
	num1.size=i+1;

	for(;i>=0;i--,j--)
	{
		if(j<0)
			num1.arr[i]=0;
		else
			num1.arr[i]=num1.arr[j];
	}
	return num1;
}
void split(Mul_Num &A,Mul_Num &B,const Mul_Num &X)
{
	int i,j;

	A.size=B.size=(X.size)/2;

	for(i=0;i<B.size;i++)
	{
		B.arr[i]=X.arr[i];
	}
	for(j=0;j<A.size;i++,j++)
	{
		A.arr[j]=X.arr[i];
	}
}
void generate(Mul_Num &num,int size)
{
	for(int i=0;i<num.size;i++)
	{
		if(i>size-1)
			num.arr[i]=0;
		else
			num.arr[i]=rand()%9;
	}
}
void display(const Mul_Num &num)
{
	int check=0;

	for(int i=num.size-1;i>=0;i--)
	{
		if(check || num.arr[i]!=0)
		{
			cout << num.arr[i];
			check=1;
		}
	}
}
int getSize(int size)
{
	int nsize=1;

	while(nsize<size)
	{
		nsize*=2;
	}
	return nsize;
}
void store(Mul_Num &num,char *s)
{
	int i,j;
	j=strlen(s)-1;
	for(i=0;i<num.size;i++,j--)
	{
		if(j<0)
			num.arr[i]=0;
		else
			num.arr[i]=s[j]-'0';
	}
}
void main()
{
	Mul_Num num1,num2,num3;
	int nsize,size,size1,size2;
	char *str1=new char[20];
	char *str2=new char[20];

	//clrscr();
	cout<<"\n\n\t MULTIPLICATION OF TWO LARGE NUMBERS";
	cout<<"\n\t*****************************************";
	cout << "\n\nEnter the 1st number : ";
	cin >> str1;
	cout << "\n\nEnter the 2nd number : ";
	cin >> str2;

	size=strlen(str1)>strlen(str2)?strlen(str1):strlen(str2);

	nsize=getSize(size);
	num1.size=num2.size=nsize;

	store(num1,str1);
	store(num2,str2);

	cout<< "\n\n1st number: ";
	display(num1);

	cout<< "\n\n2nd number: ";
	display(num2);
	num3=multiply(num1,num2);

	cout<< "\n\nThe Result is: ";
	display(num3);

	getch();
}
