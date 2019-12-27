%{
	#include<stdio.h>
	int word=0;
	int line=0;
	int chara_wos=0;
	int chara_ws=0;
	
%}
%%
[A-z]+ {word++; chara_ws+=yyleng;chara_wos+=yyleng;}
" " {chara_ws+=yyleng;}
\n {line++;chara_ws+=yyleng;}
%%
void main()
{
	yyin=fopen("Test.txt","r");
	yylex();
	printf("\n Character ws = %d \n Word = %d \n Line  = %d \n c  Wos =%d ",chara_ws,word,line,chara_wos);
	fclose(yyin);	
}
