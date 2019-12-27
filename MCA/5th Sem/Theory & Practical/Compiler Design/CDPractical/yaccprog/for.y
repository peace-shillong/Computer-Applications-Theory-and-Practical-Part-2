%{
/*Program to check for-loop syntax of the following form:for(i=0;i<=10;i++) */
#include <stdio.h>
%}
%token FOR IDEN NUM OP UOP
%%
stmt: FOR '('exp1';'exp2';'exp3')''\n' { 
						printf("\nValid!!"); 
						return;	
					}
exp1: IDEN'='IDEN {}
| IDEN'='NUM {}
exp2: IDEN OP IDEN {}
| IDEN OP NUM {}
exp3: UOP IDEN {}
| IDEN UOP {}  
%%
main()
{
	printf("\nEnter syntax of for statement: \n");
	yyparse();
	return;
}
void yyerror(char* e)
{
	printf("\nError: %s",e);
	return;
}
