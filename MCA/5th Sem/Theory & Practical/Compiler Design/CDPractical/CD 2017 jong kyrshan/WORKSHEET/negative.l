%{
#include<stdio.h>
%}
%%
^[\-][0-9]*  {printf("Negative");}
%%
void main()
{
        yylex();
}
int yywrap()
{
        return 1;
}

     
