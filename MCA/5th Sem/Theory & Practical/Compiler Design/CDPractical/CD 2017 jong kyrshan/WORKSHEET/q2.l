%{
#include<stdio.h>
%}
%option noyywrap
id[a-z]
%%
{id} {printf("%c",yytext[0]-32);}
. ECHO;
%%
void main()
{
	yylex();
	printf("Done ");	
}