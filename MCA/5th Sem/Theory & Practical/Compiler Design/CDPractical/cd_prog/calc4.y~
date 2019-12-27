%{
	#include<stdio.h>	
%}
%token NAME NUMBER
%left '+''-'
%left '*''/'
%nonassoc UMINUS
%%
stmt: NAME'='expr
	|expr {printf("=%d\n",$1);}
expr: NUMBER {$$=$1;}
	|expr'+'NUMBER {$$=$1+$3;}
	|expr'-'NUMBER {$$=$1-$3;}
	|expr'*'expr {$$=$1*$3;}
	|expr'/'expr {
		if($3==0)
			yyerror("divide by zero");
		else
			$$=$1/$3; }
	|'-'expr %prec UMINUS {$$=-$2;}
	|'('expr')'{$$=$2;}
;
%%
void main()
{
	yyparse();
}
void yyerror(char *s)
{
	fprintf(stderr,"%s",s);
}
