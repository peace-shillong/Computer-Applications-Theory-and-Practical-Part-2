%{
	//Program to count number of characters, words and lines
	#include<stdio.h>
	int cchar=0;
	int cwords=0;
	int clines=0;
%}
%%
[A-Za-z]+ {
		cchar=cchar+yyleng;
		cwords++;
		
	  }
" "+ { cchar++;  }
	
[\n] { clines++; }
%%
void main()
{
	printf("\n Enter a word : ");
	yylex();
	printf("\n Number of characters (with spaces) = %d",cchar);
	printf("\n Number of words = %d",cwords);	
	printf("\n Number of lines = %d",clines);
}
