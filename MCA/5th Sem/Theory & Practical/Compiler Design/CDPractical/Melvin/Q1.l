%{
#include <stdio.h>
%}

poss ^[0-9]+|[+][0-9]* 
%option noyywrap
%%
{poss} {printf("Positive");}
%%

void main()
{
	yylex();
}
