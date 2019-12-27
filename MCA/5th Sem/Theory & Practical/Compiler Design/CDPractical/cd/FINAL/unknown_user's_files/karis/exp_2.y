%{#include<stdio.h>
extern FILE *yyin;
%}
%token NUM;
%%
expr:NUM'+'NUM
    |NUM'-'NUM {printf("valid");}
    ;
%%
main()
{
  do{
     yyparse();
    }
   while(!eof(yyin));
}
yyerror(char *s)
{
 printf("Error");
}
