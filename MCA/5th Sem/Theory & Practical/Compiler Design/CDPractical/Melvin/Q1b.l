%{
#include <stdio.h>
%}

poss ^[-][0-9]+ 
%option noyywrap

%%
{poss} {printf("Negetive");}
%%
      
void main()
{
        yylex();
}  
