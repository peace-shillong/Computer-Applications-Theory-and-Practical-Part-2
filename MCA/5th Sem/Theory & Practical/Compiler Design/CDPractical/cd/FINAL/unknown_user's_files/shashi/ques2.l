%{
	#include<stdio.h>	

%}
vowel [AEIOUaeiou] 
%%
^{vowel}+.* {printf("\nPattern starts with vowel ");}
.* {printf("\n Patter does not starts with vowel ");}
%%
main()
{
	
	yylex();
	
}

