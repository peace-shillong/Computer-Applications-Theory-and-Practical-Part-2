%{
	/*Program to recognize Identifiers,Integer constants,Character Constants and Real number*/
	#include<stdio.h>
	
	FILE *out;
	
%}
%%
[A-Za-z][A-Za-z0-9_]+ {
			out=fopen("output.txt","a"); 
			fprintf(out,"Identifier Recognized!:%s\n",yytext);
			}
[0-9]+ {
			out=fopen("output.txt","a"); 
			fprintf(out,"Integer Constant Recognized!%\n",yytext);
			}
\'[A-Za-z]+\' {
			out=fopen("output.txt","a"); 
			fprintf(out,"Character constant Recognized!:%s\n",yytext);
			}
[0-9]+\/[1-9]+ {
			out=fopen("output.txt","a"); 
			fprintf(out,"Fractional Real Number Recognized!:%s\n",yytext);
			}
[0-9]+\/[0]+ {
			out=fopen("output.txt","a"); 
			fprintf(out,"Invalid entry cannot divide by zero!:%s\n",yytext);
			}
[0-9]+\.[0-9]+E\+[0-9] {
			out=fopen("output.txt","a"); 
			fprintf(out,"Exponential Real Number Recognized!:%s\n",yytext);
			}
.+ {
			out=fopen("output.txt","a"); 
			fprintf(out,"Invalid Entry!:%s\n",yytext);
			}
%%
void main()
{
	printf("Enter Identifier ,Constants or Real Numbers or Press ctrl+c to exit:");
	yylex();
	
}

