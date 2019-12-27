%{
#include <stdio.h>
%}

n [-|+]?[0-9]+[.][0-9]+[E][+][0-9]+

%option noyywrap
%%
{n} {printf("floating");}
%%

void main() 
{   
        yylex();
}
