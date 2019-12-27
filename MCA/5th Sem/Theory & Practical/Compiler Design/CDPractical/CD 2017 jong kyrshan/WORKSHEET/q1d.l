%{
#include<stdio.h>
%}
%option noyywrap
%%
(-|\+)?[0-9]+\.[0-9]*E(-|\+)[0-9]+ {printf("VALID");}
%%

void main()
{
	yylex();
}
