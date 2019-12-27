%{
#include<stdio.h>
int no;
%}
%option noyywrap
%%
^0*10*10*$ {printf("Binary String Accepted");}
%%

void main()
{
	yylex();
}
