%{
#include<stdio.h>
int f=0;			
%}
%%
[Aa][Nn][Dd]|[Oo][Rr]|[Bb][Uu][Tt]	f=1; 
%%
main()
{
	printf("Enter a sentence\n");
	yylex();
	if(f==1)
		printf("Compound sentence");
	else
		printf("Simple sentence");
}
