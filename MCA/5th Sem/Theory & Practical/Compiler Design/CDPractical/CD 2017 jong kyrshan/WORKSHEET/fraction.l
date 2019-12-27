%{
#include<stdio.h>
%}
%%
^[\+|\-]?[0-9]*\/[0-9]*  {printf("Fraction");}
.* {printf("Not a fraction");}
%%
void main()
{
        yylex();
}
int yywrap()
{
        return 1;
}

     
