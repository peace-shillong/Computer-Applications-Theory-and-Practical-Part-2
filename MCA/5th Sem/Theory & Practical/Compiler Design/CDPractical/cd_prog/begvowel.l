%{
	#include<stdio.h> 
%}
words [A-Za-z]+
vowels [a|A|e|E|i|I|o|O|u|U]+
consonant [b|B|c|C|d|D|f|F|g|G|h|H|j|J|k|K|l|L|m|M|n|N|p|P|q|Q|r|R|s|S|t|T|v|V|w|W|x|X|y|Y|z|Z]+
%%
{vowels}{words} {printf("\n The word starts with a vowel");}
{consonant}{words} {printf("\n The word does not starts with a vowel");}
%%
void main()
{
	yylex();
}
