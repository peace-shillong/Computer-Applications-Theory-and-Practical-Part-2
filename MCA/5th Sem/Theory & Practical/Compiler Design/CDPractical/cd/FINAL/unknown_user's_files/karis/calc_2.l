%{#include "y.tab.h"
extern int yylval;
%}
%%
[0-9]+ {yyval=atoi(yytext);return NUMBER}
[\t]
\n return 0;
return yytext[0];
%%
