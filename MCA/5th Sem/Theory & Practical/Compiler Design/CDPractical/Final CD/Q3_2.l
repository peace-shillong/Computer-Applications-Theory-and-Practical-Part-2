%{
	#include<stdio.h>
	int cchar=0;
	int cwords=0;
	int clines=0;
%}
%%
[A-Za-z]+[ ]* { 
		cchar=cchar+yyleng; 
		cwords++;
	      }
[\n] {	clines++; }

%%
void main()
{
	yyin=fopen("hello.txt","r");
	yylex();
	printf("\n Number of characters = %d \n",cchar);
	printf("\n Number of words = %d \n",cwords);
	printf("\n Number of lines = %d \n",clines);
	fclose(yyin);
}
