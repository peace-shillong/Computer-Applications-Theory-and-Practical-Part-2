%{
	//program to identify octal and hexadecimal number
	#include<stdio.h>
	
%}
oct [o][0-9]+
hex [o][x|X][0-9A-F]+
%%
{oct} {
	printf("\n\t It is an octal number\n");
	}
{hex} {
	printf("\n\t It is hexadecimal number\n");
	}

%%
main()
{
	printf("\n Enter any number: ");
	yylex();
}