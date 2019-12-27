%{
#include <stdio.h>
#include <string.h>
char expx[100];
int c=0,i;
%}

test [0|1]*
%option noyywrap
%%
{test} {
	c=0;
	strcpy(expx,yytext);
	for(i=0;i<yyleng;i++)
	{
		if(expx[i]=='1')
		{
			c++;		
		}
	}
	
	if(c<=2)
	{
		printf("correct");
	}
	else
	if(c>2)
	{
		printf("Extra 1s");
	}
	else
	{
		printf("Extra 1s");
	}
  }

%%

void main()
{
        yylex();
}
