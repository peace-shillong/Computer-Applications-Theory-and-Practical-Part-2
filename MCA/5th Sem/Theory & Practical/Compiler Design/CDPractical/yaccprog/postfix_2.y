%{
#include<stdio.h>
/*	YACC program to read a postfix expression from user and print the result.
	The expression contains +,-,*,/,^ operators along with numbers.
	To specify a number with more than one digit leave a space between numbers.
	For example: 12 2/3 + 2 2 ^ - 
	Result = 5 
*/
%}
%token NUM
%%
stmt: exp '\n' { printf("\n=%d\n",$1); return;}
exp: exp exp '+' { $$=$1+$2;}
| exp exp '-' { $$=$1-$2;}
| exp exp '*' { $$=$1*$2;}
| exp exp '/' { $$=$1/$2;}
| exp exp '^' { $$=power($1,$2);}
| NUM { $$=$1;}
%%
main()
{
	printf("\nEnter postfix expression for evaluation:\n");
	yyparse();
	return;
}
int power(int a, int b)
{
	int i,p=1;
	for(i=1;i<=b;i++)
	{
		p=p*a;
	}
	return p;
}
void yyerror(char *e)
{
	printf("\n%s\n",e);
	return;
}

