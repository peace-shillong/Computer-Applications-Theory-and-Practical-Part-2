%{
#include <stdio.h>
int count=0;
%}

%option noyywrap
%%
[aeiou] {count++;}
\n {printf("%d",count); 	count=0;}
. {printf("");}
%%

void main() 
{   
       yylex();
}
