%{
#include <stdio.h>
%}

t ^[A-z]+[0-9]*[A-z]*
%option noyywrap

%%
{t} {printf("%s is an identifier",yytext);}
%%

void main()
{
        yylex();
}                        
