%{
	#include<stdio.h> 
%}
words [A-Za-z]+
vowel [a|A]+
%%
{vowel}{words}{vowel} {printf("\n The word starts with a vowel and ends with a vowel a");}
[^[vowel]{words}] {printf("\n The word does not starts with a vowel a");}
%%
void main()
{
	yylex();
}
