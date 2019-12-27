%{
#include<stdio.h>
%}
DIGIT [0-9]
%%
{DIGIT}+ { printf("\nIs valid: %s",yytext);}
. { printf("\ninvalid");}
%%
main()
{
	yylex();
}
