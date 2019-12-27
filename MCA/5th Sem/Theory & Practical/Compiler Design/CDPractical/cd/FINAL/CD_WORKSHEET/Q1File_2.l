%{
	//program to count number of characters from the file
	#include<stdio.h>
	int total = 0;
%}
%%
.+ {
	printf("\n\t %s ",yytext);
	total+=yyleng;
	}
%%
main()
{
	yyin = fopen("test.txt","r");
	yylex();
	printf("\n\n\t Total Number of characters = %d \n\t",total);
}
