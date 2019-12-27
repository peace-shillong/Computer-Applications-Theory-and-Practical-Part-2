%{

	//Program to identify words and numbers

	#include<stdio.h>
	int total=0;

%}

%%
[A-za-z]+  {
		printf("\n %s \n Character count = %d \n",yytext,yyleng);
		total = total+yyleng;
	}
%%

void main()
{
	yylex();
	printf("\n Total = %d \n",total);
	
}
