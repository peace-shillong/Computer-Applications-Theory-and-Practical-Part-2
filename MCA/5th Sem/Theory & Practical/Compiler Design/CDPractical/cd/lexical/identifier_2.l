%{
	/*check valid identifier*/
	#include<stdio.h>
%}
%%
[A-z][A-z0-9_]* {printf("\nYou entered a valid identifier...\n");}
.+ {printf("\nInavlid identifier...\n");}
%%
main()
{
	printf("\nEnter an identifier:\t");
	yylex();
	printf("\nEND");
}
