%{
	#include<stdio.h>
	/*Program to read from a file and display its contents one line at a time. Each line should begin with a line number*/
	int lineno=0;
%}
%%
.+[\n] { printf("%d. %s",++lineno,yytext); }
%%
int main()
{
	yyin=fopen("hello.txt","r");
	yylex();
	fclose(yyin);
	return 0;
}