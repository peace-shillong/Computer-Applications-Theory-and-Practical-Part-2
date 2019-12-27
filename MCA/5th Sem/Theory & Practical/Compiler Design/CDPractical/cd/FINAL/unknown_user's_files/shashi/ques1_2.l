%{

	#include<stdio.h>
	char name[20];
%}
%%
[\n] {printf("welcome %s",name); /* action */} 
%%
main()
{
	printf("\n Enter your name :");
	scanf("%s",name);
	yylex();
}
