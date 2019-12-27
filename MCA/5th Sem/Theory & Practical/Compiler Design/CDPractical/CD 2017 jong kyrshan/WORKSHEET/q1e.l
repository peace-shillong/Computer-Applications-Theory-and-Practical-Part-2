%{
#include<stdio.h>
%}
%option noyywrap
%%
"Compiler Design"[\n] {printf("\nCompiler Design is fun!\n");}
%%

void main()
{
	yylex();
}
