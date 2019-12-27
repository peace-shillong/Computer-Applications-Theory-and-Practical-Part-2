%{
	#include "y.tab.h"
	//yylval is a variable identified by both lex and yacc
	extern int yylval;
%}
%%
[0-9]+ {
	yylval = atoi(yytext);
	return NUM;
	}
[+\-\*/\n] {return *yytext;}
. {}
%%
