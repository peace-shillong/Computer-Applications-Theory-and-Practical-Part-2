%{
/*YACC program evaluating C ternary operator*/
#include<stdio.h>
int ans;
%}
%token NUM WORD GT EQ LT NEQ
%%
stmt: exp'?'WORD':'WORD';''\n' { 
	if($$==1)
		printf("\n%s\n","true");
	else
		printf("\n%s\n","false");
	return;
 }
exp: exp'>'NUM { 
		if($1>$3)
			$$=1;
		else
			$$=0;
	}
 |exp'<'NUM {
		if($1<$3)
			$$=1;
		else
			$$=0;
	}	
 |exp GT NUM {
		if($1>=$3)
			$$=1;
		else
			$$=0;
	}
 |exp LT NUM {
		if($1<=$3)
			$$=1;
		else
			$$=0;
	}
 |exp EQ NUM {
		if($1==$3)
			$$=1;
		else
			$$=0;
	}
 |exp NEQ NUM {
		if($1!=$3)
			$$=1;
		else
			$$=0;
	}
 |NUM {$$=$1;}
%%
main()
{
	printf("\nEnter ternary operator expression:");
	yyparse();
	return;
}
void yyerror()
{
	printf("\nEnter expression e.g: 1<3?true:false\n");
	return;
}
