%{
/*1>3?5:7*/
#include<stdio.h>
char *res;
%}
%union{
	double number
	char *result
}
%token <number> NUM 
%token <result> WORD 
%token GT EQ LT NEQ
%%
stmt: exp'?'stmt2'\n' { 
	if($$==1)
		printf("\n%s\n",res);
	else
		printf("\n%s\n",res);
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
stmt2: stmt2':'WORD {
		if($$==1)
			res=$1;
		else
			res=$2;
	}
 |WORD {$$=$1;}
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
