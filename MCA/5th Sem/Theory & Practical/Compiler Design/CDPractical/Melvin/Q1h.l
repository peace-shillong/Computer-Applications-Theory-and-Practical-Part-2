%{
#include <stdio.h>
%}

%option noyywrap
%%
{test} {printf("YES");} 
%%

void main() 
{   
        yylex();
}
