%{
	//program to count number of words from file
	#include<stdio.h>
	int cw = 0;
%}
%%
[A-z]+ {
		printf("%s",yytext); 
		cw++;
	}
	
%%
main()
{
	yyin = fopen("test.txt","r");
	yylex();
	printf("\n\t Number of words = %d\n",cw);
	fclose(yyin);
}
