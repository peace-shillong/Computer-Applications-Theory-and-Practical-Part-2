%{
#include<stdio.h>
%}
%option noyywrap
op [+]
no [0-9]+
mul[\*]
div[/]
minus[-]
%%
{no}{op}{no} {printf("SUM is %d",(yytext[0]-48)+(yytext[2]-48));}
{no}{minus}{no} {printf("Difference is %d",(yytext[0]-48)-(yytext[2]-48));}
{no}{div}{no} {printf("Division is %d",(yytext[0]-48)/(yytext[2]-48));}
{no}{mul}{no} {printf("Multiplication is %d",(yytext[0]-48)*(yytext[2]-48));}
. {printf("%d",(int)yytext);};
%%
void main()
{
	yylex();	
}
