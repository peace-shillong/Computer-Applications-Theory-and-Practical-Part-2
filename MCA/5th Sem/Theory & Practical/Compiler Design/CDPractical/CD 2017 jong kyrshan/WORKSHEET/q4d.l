%{
#include<stdio.h>
%}
%option noyywrap
%%
^0*1*110*1*$ {printf("Binary String Accepted");}
%%

void main()
{
	yylex();
}
