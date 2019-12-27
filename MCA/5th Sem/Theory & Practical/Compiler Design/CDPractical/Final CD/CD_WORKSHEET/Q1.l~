%{
	//Program to count number of characters
	#include<stdio.h>
	int total = 0;
%}
%%
.+ {printf("\n\t Total number of character in %s = %d ",yytext,yyleng);
	
	}
%%
main()
{
	yylex();
}
