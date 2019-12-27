%{
	#include<stdio.h>
	int cword=0;
	int cline=0;
	int cchar=0;
	
%}

%%

[A-Za-z]+ {	cchar=cchar+yyleng;
		cword++;
	}

[\n] {
		cline++;
     }
	
%%
void main()
{
	yyin=fopen("hello.txt","r");
	yylex();
	printf("\n Total number of words = %d",cword);
  	printf("\n Total number of lines = %d",cline);
	printf("\n Total number of characters = %d",cchar);	
	fclose(yyin);
}
