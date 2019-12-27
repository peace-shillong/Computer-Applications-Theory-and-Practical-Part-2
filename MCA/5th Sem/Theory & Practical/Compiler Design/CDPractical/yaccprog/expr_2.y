%{
#include <stdio.h>
float powFn(float a,float b);
%}
%union{
 float x; 	
}
%token <x> NUM
%type <x> exp

%left '+' '-'
%left '*' '/'
%left '^'
%right UMINUS
%%
stmt: exp '\n' { printf("\nThe result = %f",$1);}
exp:exp '^' exp {$$=powFn($1,$3);} 
 |exp '*' exp { $$=$1*$3;}
 |exp '/' exp { $$=$1/$3;}
 |exp '+' exp { $$=$1+$3;}
 |exp '-' exp { $$=$1-$3;}
 |'-'exp %prec UMINUS {$$=-$2; /*%prec means assigning the precedence to Unnary '-' otherwise it will b taken as precedence of Binary '-'*/}
 |NUM {$$=$1;}
%%
main()
{
	printf("\nEnter arithmetic expression: \n");
	yyparse();
	return;
}	
float powFn(float a,float b)
{
	int i;
	float pow=1;
	for(i=1;i<=b;i++)
		pow=pow*a;	
	return pow;
}
void yyerror()
{
	printf("\nEnter expression for adding\n");
	return;
}
