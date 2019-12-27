%{
#include<stdio.h>
int no;
%}
%option noyywrap
%%
^[0-9]+$ {no=atoi(yytext); printf("%d in HEXA is %04x",no,no);}
%%

void main()
{
	yylex();
}
