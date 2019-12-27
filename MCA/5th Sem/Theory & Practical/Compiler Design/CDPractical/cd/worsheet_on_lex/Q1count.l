%{
	#include<stdio.h>
	int count = 0;
%}
%%
.+ {count = count+yyleng;}
%%
void main()
{
	yyin = fopen("file1.txt","r");
	yylex();
	printf("\n\tnumber of characters in file is %d\n\t",count);
	fclose(yyin);
}
