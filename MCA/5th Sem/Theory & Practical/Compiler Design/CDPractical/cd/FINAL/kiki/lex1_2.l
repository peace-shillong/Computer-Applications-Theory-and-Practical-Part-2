
%{
	#include<stdio.h>
%}

%%
[\n] { printf("\n Welcome to programming with Flex \n"); }
%%

main()
{
	printf("\n Keep Pressing enter \n");
	yylex();
}
