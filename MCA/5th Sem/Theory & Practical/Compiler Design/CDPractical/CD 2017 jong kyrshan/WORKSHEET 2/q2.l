%{
#include<stdio.h>
int count=0;
int counts=0;
%}
%option noyywrap
%%
[A-Z|a-z|0-9] {count++;}
[' '] {counts++;}
['\n'] {printf("Counted %d character(s)\n",count); printf("Counted %d word(s)\n",counts);}
.* {}
%%

void main()
{
	yyin=fopen("in.txt","r");
	yylex();
	count=0;
}