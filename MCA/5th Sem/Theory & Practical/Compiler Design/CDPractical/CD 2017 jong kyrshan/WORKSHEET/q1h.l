%{
#include<stdio.h>
%}
%option noyywrap
vowel [aeiou]
%%
[^{vowel}]*a+[^{vowel}]*e+[^{vowel}]*i+[^{vowel}]*o+[^{vowel}]*u+[^{vowel}]* {printf("Accepted");}
.* {printf("");}
%%
void main()
{
	yylex();	
}
