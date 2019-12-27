%{
#include <stdio.h>
%}

n "Compiler Design"
%option noyywrap
%%
{n} {printf("%s is fun",yytext);}
%%

void main() 
{   
        yylex();
}      
