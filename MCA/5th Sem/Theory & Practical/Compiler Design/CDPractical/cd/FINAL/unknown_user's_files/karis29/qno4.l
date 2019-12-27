%{
  #include<stdio.h>
%}
digit[0-9]
sign[+-]
%%
{digit}*{printf("\n Integer recognised");
%%
main()
{
  yylex();
}   
