
%{

	#include<stdio.h>
%}


%%

[A-Za-z]+[\n] {	printf("\n Word is found \n"); }
[0-9]+[\n] {	printf("\n Number is found \n"); }
.+ { ECHO; printf("\n"); }
%%

main()
{
	printf("\n Enter either number or word: ");
	yylex();
	printf("\n End of Program \n");
}

