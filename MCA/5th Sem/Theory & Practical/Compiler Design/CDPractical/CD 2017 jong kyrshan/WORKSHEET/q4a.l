%{
#include<stdio.h>
%}
%option noyywrap
%%
^11$ {printf("Binary String Accepted");}
.* {printf("");};
%%

void main()
{
	yylex();
}
