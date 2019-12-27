%{
#include<stdio.h>
%}
%option noyywrap
%%
"Prakash" {printf("Hello");}
%%
void main()
{
	yylex();
}
