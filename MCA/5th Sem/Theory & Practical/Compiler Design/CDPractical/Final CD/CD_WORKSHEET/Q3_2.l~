%{
	//program to count number of words from file
	#include<stdio.h>
	int cw = 0;
	int cl = 0;
%}
%%
[A-z]+ {
		cw++;
	}
\n cl++;
	
%%
main()
{
	yyin = fopen("test.txt","r");
	yylex();
	printf("\n\t Number of words = %d\n",cw);
	printf("\n\t Number of lines = %d\n",cl);
	fclose(yyin);
}
