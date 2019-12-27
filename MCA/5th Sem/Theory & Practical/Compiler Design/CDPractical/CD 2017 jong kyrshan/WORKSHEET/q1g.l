%{
#include<stdio.h>
int count=0;
%}
%option noyywrap
%%
[aeiou] {count++;}
. {printf("");}
[\n] {printf("\n counted %d vowels",count); count=0;}
%%

void main()
{
	yylex();
//	printf("\n counted %d vowels",count);
}
