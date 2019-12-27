%{
	//program to create a symbol table that store identifiers as well as arithmatic operators entered by the user
	#include<stdio.h>
	FILE *fp;
%}
%%
[A-z]+[A-z0-9_]* {fp = fopen("symboltable2.txt","a");
		fprintf(fp,"identifier: %s\n",yytext);
	}	
[\+2\-2\+\-\*\/%]+ {fp = fopen("symboltable2.txt","a");
                fprintf(fp,"operator: %s\n",yytext);
        }
[\/]{1}[\*]{1}[.]{*}[\*]{1}[\/]{1} {fp = fopen("symboltable2.txt","a");
                	fprintf(fp,"operator: %s\n",yytext);
		}
%%
void main()
{
	printf("\n\tEnter the identifier...");
	yylex();
	fclose(fp);
}
