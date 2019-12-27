%{
	// Check digit or a word
	#include<stdio.h>
%}
digit [0-9]+ 
word [A-Za-z]+
%%
{digit} {printf("It is a number",yytext);}
{word} {printf("It is a word",yytext);}
.+ {printf("It is combine with word and numbers",yytext);}
%%
void main()
{
	printf("Enter anything:");
	yylex();
}


