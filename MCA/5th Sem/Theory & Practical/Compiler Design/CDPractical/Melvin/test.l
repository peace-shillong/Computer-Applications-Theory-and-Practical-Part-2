%{
#include <stdio.h>
%}

letter [A-z]+
%option noyywrap
%%

{letter} {printf("correct");}

%%

void main()
{
	yylex();
}
