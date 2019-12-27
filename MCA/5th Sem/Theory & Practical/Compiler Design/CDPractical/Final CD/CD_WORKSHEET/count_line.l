%{
	//program to count number of lines
	#include<stdio.h>
	int cntline = 0;
%}
%%
\n {	
		
		cntline++;
		printf("line = %d",cntline);
	}
%%
main()
{
	yylex();
	
}
