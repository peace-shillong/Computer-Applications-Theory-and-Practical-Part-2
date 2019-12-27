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
		if(expx[i]=='1' && expx[i+1]=='1')
		{
			c++;		
		}
	}
	
	if(c>0)
	{
		printf("correct");
	}
	else
	{
		printf("Incorrect");
	}
  }

. {printf("");}

%%

void main()
{
        yylex();
}
