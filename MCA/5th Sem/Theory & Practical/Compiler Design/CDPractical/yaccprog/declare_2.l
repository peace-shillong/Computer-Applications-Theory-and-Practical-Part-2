%{
#include "y.tab.h"
int line_no=1;
%}
TYPE int|float|char|double
IDEN [a-zA-Z]+[a-zA-Z0-9_]*
%%
{TYPE} { return TYPE;}
{IDEN} { return IDEN; }
[,;] { return *yytext;}
[\n] { line_no++; }
. {}
%%
