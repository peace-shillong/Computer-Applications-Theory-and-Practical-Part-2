%{
	#include<stdio.h>
%}
digit [0-9]
sign [+-]
%%
{digit}* {printf("\n\n Integer recognized ");}
%%
main()
{
	yylex();
}
