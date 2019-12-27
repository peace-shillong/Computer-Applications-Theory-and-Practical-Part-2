%{
#include <stdio.h>
#include <string.h>
char a[100];
int i;
%}

test [a-z]+
%option noyywrap
%%
{test} {

strcpy(a,yytext);
	
	for(i=0;i<yyleng;i++)
		printf("%c",a[i]-32);
}
. {printf("No");}
%%

void main() 
{   
        yylex();
}
