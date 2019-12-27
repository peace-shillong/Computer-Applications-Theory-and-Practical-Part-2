%{
	#include "y.tab.h"
	extern int yylval;
%}
keyword true|false
%%
"<=" {return LTE;}
">=" {return GTE;}
"==" {return EQ;}
"!=" {return NE;}
[0-9]+ {
	yylval = atoi(yytext);
	return NUM;}
{keyword} {
		return CHOICE;
		;}
[;\n?><:] {return *yytext;}
. {}
%%
