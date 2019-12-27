%{
  #include<stdio.h>
%}
%token NAME NUMBER
%%
stmt: NAME'='expression
    |expression {printf("=%d\n",$1);}
expression:expression'+'NUMBER  {$s=$1+$3;}
          |expression'-'NUMBER{$s=$1-$$3;}
          |NUMBER
          ;
%%
extern FILE *yyin;
main()
{
 do{
    yyparse();
   }
  while(!feof)


