%{
#include<stdio.h>
      
%}
%%
[0-9]+\.[0-9]+[E][\-\+][0-9]+ {printf("%s is a complete precision number",yytext);}
.* {printf("%s is not a complete precision number",yytext);}
%%

void main()
{
        yylex();
}


