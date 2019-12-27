%{
/*program to check for a word containig small, capital,or a number and for a number*/
#include<stdio.h>
%}
%%
[A-z]+ {printf("\nYou entered a word..\n");}
[0-9]+ {printf("\nYou entered a number..\n");}
.+ {ECHO;printf("\n");}
%%
main()
{
	printf("\nEnter a number or a word:\t");
	yylex();
	printf("\nEnd of the program..\n\n");
}
