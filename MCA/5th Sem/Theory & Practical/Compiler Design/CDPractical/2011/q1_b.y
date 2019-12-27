%{
#include<stdio.h>
%}
%token NUMBER
%%
stmt: exp '\n' { printf("\n=%d\n",$1); return;}
exp: exp exp '+' { $$=$1+$2;}
| exp exp '-' { $$=$1-$2;}
| exp exp '*' { $$=$1*$2;}
| exp exp '/' { $$=$1/$2;}
| exp exp '^' { $$=power($1,$2);}
| NUMBER { $$=$1;}
%%
main()
{
	printf("\n*****Please!Enter the postfix expression*****:\n");
	yyparse();
	return;
}
int power(int a, int b)
{
	int i,pow=1;
	for(i=1;i<=b;i++)
	{
		pow=pow*a;
	}
	return pow;
}
void yyerror(char *e)
{
	printf("\n%s\n",e);
	return;
}

