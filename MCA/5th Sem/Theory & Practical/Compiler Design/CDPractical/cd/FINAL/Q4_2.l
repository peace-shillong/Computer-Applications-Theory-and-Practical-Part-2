%{
	#include<stdio.h>

%}
%%
[A-z]+[0-9_]+[\n] { 
		printf("\n Identifiers identified \n"); 
	}
[0-9]+[\n] { printf("\n Number is identified \n"); }
[if|else|goto] {
		 printf("\n Keywords identified \n"); 
	}
.+ { ECHO; }
%%
void main()
{
	
	yylex();
	
}

