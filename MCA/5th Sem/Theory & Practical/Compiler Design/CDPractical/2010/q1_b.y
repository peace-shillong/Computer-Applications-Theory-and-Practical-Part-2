%{
#include<stdio.h>
int result=0;
%}
%token number
%left '+' '-'
%left '*' '/'
%%
stmt:expr {result=$$;}
;
expr:expr '+' expr {$$=$1+$3;}
    |expr '-' expr {$$=$1-$3;}
    |expr '*' expr {$$=$1*$3;}
    |expr '/' expr {if($3==0)
             exit(0);
             else $$=$1/$3;}
    |number
    ;
%%
void main()
{
printf(" Please!enter expression\n");
yyparse();
printf("valid=%d",result);
exit(0);
}

void yyerror()
{
printf("invalid\n");
exit(0);
}
  

