%{
	//program to count number of words from files
	#include<stdio.h>
	int cntword = 0;
%}
%%
[^ \t\n]+ {
		
		printf(" %s ",yytext);		
		cntword++;
	}

%%
main()
{
	yyin = fopen("test.txt","r");
	yylex();
	printf("\n\t Total number of word = %d \n\t",cntword);
	
}
