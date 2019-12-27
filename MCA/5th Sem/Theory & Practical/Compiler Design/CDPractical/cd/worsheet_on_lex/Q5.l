%{
	#include<stdio.h>
%}
%%
[0][xX][0-9A-F]+ {printf("\n\tYou entered a hexadecimal number ..\n\n\t");}
[0-7]+ {printf("\n\tYou entered a octal number ..\n\n\t");}
.* {printf("\n\tNot octal or hexadecimal..");}
%%
void main()
{
	printf("\n\n\tprint your number...");
	yylex();
}
