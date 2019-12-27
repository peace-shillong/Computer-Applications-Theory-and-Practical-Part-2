%{
#include<stdio.h>
%}
%option noyywrap
id [A-z]
op [=\+-/\*\\]
no [0-9]
%%
{id}+{no}*{op}*{op}{op}*{id}*{no}*{op}*{id}*{no}* {printf("Accepted Expression");}
.* {printf("");}
%%
void main()
{
	yylex();	
//	[A-z]+[0-9]*=[A-z]+[0-9]*[\+][A-z]*[0-9]* {printf("Accepted Expression 1");}
}