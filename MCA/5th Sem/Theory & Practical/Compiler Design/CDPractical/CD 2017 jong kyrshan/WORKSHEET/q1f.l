%{
#include<stdio.h>
%}
%option noyywrap
%%
^[A-z]+[0-9]* {printf(" %s is an identifier",yytext);}
%%

void main()
{
	yylex();
}
