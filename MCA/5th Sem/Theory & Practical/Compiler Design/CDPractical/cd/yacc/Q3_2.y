%{
	//declaration recognisation
	#include<stdio.h>
%}
%token KEYWORD
%token IDENTIFIER
%%
stmt: KEYWORD expr';''\n' {printf("\n\n\tvalid");}
expr: IDENTIFIER
| IDENTIFIER','expr
%%
void main()
{
	printf("\n\tEnter declaration statement:\t");
	yyparse();
}
void yyerror()
{
	printf("\n\tInalid input\n\n");
	return;
}
