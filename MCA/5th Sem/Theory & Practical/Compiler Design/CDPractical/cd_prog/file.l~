%{
	#include<stdio.h>
	int cw=0,cl=0,ch=0;
%}
%%
[a-zA-Z] {yytext;cw++;ch+=yyleng;}
[\n] {yytext;cl++;}
%%
void main()
{
	yyin=fopen("text.txt","r");
	yylex();
	printf("The number of word are:%d\n",cw);
	printf("The number of character are:%d\n",ch);
	printf("The number of lines are:%d\n",cl);
	
}
