%{
/*declaration statement*/
#include<stdio.h>
FILE *yyin;
extern int line_no;
char filename[50];
%}
%token TYPE IDEN
%%
stmt: TYPE stmt2 {
	printf("\nValid Declaration in Line No: %d",line_no);
	//printf("\nValid\n");
	return;
 }
stmt2: IDEN ',' stmt2 {}
	|IDEN ';' {}
%%
main()
{
	printf("\nEnter a C filename:");
	scanf("%s",&filename);
	yyin=fopen(filename,"r");
	//printf("Enter declaration statement: ");
	do{
		yyparse();
	}while(!feof(yyin));
	return;
}
void yyerror()
{
	//(char *err)
	//fprintf(stderr,"%d%s\n",line_no,err);	
	//return;
}
