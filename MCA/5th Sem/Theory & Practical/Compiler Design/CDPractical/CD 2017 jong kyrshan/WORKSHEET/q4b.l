%{
#include<stdio.h>
%}
%option noyywrap
%%
0*11+0*1* {printf("Binary String Accepted");}
.* ECHO;
%%

void main()
{
	yylex();
}