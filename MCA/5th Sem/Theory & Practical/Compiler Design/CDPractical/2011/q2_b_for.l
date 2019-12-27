%{
	#include "y.tab.h"
%}
unary "++"|"--"
digit [0-9]+
%%
"for" { return FOR;}
[a-z]+[a-zA-Z_]* { return IDEN;}
">="|"<="|"=="|"!=" { return OP;}
{digit} { return NUM;}
{unary} { return UOP;}
[><] { return OP;}
[();=] { return *yytext;}
\n { return *yytext;}
. {}
%%
