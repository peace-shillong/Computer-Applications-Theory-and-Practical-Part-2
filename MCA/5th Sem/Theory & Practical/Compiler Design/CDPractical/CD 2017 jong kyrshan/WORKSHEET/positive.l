%{
#include<stdio.h>
%}
%%
^[\+]?[0-9]*  {printf("Positive");}
%%
void main()
{
	yylex();
}
int yywrap()
{
	return 1;
}

