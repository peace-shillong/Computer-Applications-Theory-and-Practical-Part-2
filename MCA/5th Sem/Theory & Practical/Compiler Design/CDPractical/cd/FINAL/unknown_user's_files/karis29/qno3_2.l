%{
  #include<stdio.h>
%}
vowel[AEIOUaeiou]
%%
^{vowel}+.*{prinft("\n pattern starts with vowel");}
.*{printf("\npattern doesnot start with vowel");}
%%
main()
{
  yylex();
}
