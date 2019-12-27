%{
#include <stdio.h>
%}

n [+|-]?[0-9]+[/][+|-]?[0-9]?[1-9]+
mm [^n]
%option noyywrap
%%
{n} {printf("fraction");}
{mm} {printf("Not");}
%%

void main()
{
        yylex();
}
