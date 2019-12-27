%{
	#include "y.tab.h"
	extern int yylval;
%}
keyword int|float|double|char
%%
{keyword} {return KEYWORD;}
[a-zA-Z][a-zA-Z0-9_]* {yylval = atoi(yytext);
			return IDENTIFIER;}
[;\n,] {return *yytext;}
. {}
%%
