%{
#include<stdio.h>
%}
%%
[0-7]+ {printf("It is an octal number:");}
[0][xX][0-9A-F]+ {printf("It is an hexadecimal number");}
.* {printf("Neither octal nor hexadecimal");}
%%

void main()
{
	yylex();
}
