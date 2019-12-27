%{
	// identify 12>3?true:false;
	#include<stdio.h>
	//char c[10];
	//int res;
%}
%token NUM CHOICE
%token LTE GTE NE EQ
%%
stmt: expr1 '?' expr2 ';' '\n' {if($1==1)
					printf("true");
				else 
					printf("false");
				return;}
expr1: NUM LTE NUM {if($1<=$3)
                        $$ = 1; 
                else
                        $$ = 0;}
| NUM GTE NUM {if($1>=$3)
                        $$ = 1; 
                else
                        $$ = 0;}
| NUM EQ NUM {if($1==$3)
                        $$ = 1; 
                else
                        $$ = 0;}
| NUM NE NUM {if($1!=$3)
                        $$ = 1; 
                else
                        $$ = 0;}
| NUM '>' NUM {if($1>$3)
                        $$ = 1;
                else
                        $$ = 0;}
| NUM '<' NUM {if($1<$3)
                        $$ = 1; 
                else
                        $$ = 0;}

expr2:CHOICE ':' CHOICE {}
%%
void main()
{
	printf("\n\tEnter expression eg : number ? number :");
	yyparse();
}
void yyerror()
{
	printf("\n\terror input format...");
	return;
}
