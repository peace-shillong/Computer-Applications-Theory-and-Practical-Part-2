%{
#include<stdio.h>
int count=0;
%}
%option noyywrap
%%
[0-9]+ {count++;}
['\n'] {}
.* {}
%%

void main()
{
	yyin=fopen("in.txt","r");
	yylex();
	printf("Counted %d integer(s)\n",count);
	count=0;
}
