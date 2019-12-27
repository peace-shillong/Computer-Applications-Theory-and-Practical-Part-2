%{
	//program to count number of words
	#include<stdio.h>
	int total = 0;
%}
%%
[^ \t\n]+ {
		
		total++;
	}
[\n] {
	printf("\n\t Number of words = %d\n",total);
	}
%%
main()
{
	yylex();
	
}
