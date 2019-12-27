%{
#include "y.tab.h"
%}
DIGIT [0-9]+|[0-9]*\.][0-9]+
KEYWORD true|false
%%
{DIGIT} { 
		yylval.number=atof(yytext);
		printf("\n%lf\n",yylval.number);
		return NUM; 
 }
{KEYWORD} { 	
			strcpy(yytext,yylval.result);
			printf("%s",yytext);
			return WORD; 
 }
[=]{2} { printf("\nEQ\n"); return EQ; }
">=" { printf("\nGT\n"); return GT;}
"<=" { printf("\nLT\n"); return LT;}
"!=" { printf("\nNEG\n"); return NEQ;}
[\n>;:?<] {printf("\n%s\n",yytext);return *yytext;}
. {}
%%
