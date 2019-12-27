%{
	//program to count number of words,character without space,character with space and lines from files
	#include<stdio.h>
	int cntwrd = 0;
	int char_s = 0;
	int char_ws = 0;
	int cntline = 0;
	
%}
%%

[A-z]+ {
		cntwrd++;
		char_s+=yyleng;
		char_ws+=yyleng;
		}

" " char_s+=yyleng;		
\n cntline++;

%%
main()
{
	yyin = fopen("test.txt","r");	
	yylex();
	printf("\n\t Words = %d\n",cntwrd);
	printf("\n\t Character(with space) = %d\n",char_s);
	printf("\n\t Character(without space) = %d\n",char_ws);
	printf("\n\t lines = %d\n",cntline);
	fclose(yyin);
}
