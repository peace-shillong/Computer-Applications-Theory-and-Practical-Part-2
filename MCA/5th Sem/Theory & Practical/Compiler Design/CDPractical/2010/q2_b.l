%{
#include "y.tab.h"
extern int yylval;
%}
DIGIT [0-9]+
KEYWORD true|false
%%
{DIGIT} { 
		yylval=atoi(yytext);
		printf("\n%d\n",yylval);
		return NUM; 
 }
{KEYWORD} { printf("%s",yytext);return WORD; }
[=]{2} { printf("\nEQ\n");return EQ; }
">=" { 	printf("\nGT\n"); return GT;}
"<=" { printf("\nLT\n"); return LT;}
"!=" { printf("\nNEG\n");return NEQ;}
[\n>;:?<] {printf("\n%s\n",yytext);return *yytext;}
. {}
%%
