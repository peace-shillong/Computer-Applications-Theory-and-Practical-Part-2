%{
 #include"y.tab.h"

%}
%%
[0-9]+ {return NUM;}
[\n]   {return yytext;}
%%


