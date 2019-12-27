%{
#include "y.tab.h"
//extern int  yylval;
%}
DIGIT [0-9]+|[0-9]*\.[0-9]+
%%
{DIGIT} { 
		//yylval=atoi(yytext);
		yylval.x=atof(yytext);
		printf("\n%f\n",yylval.x);
		return NUM;
 }
[\^+*\n\-/] { return *yytext; }
. {}	
%%
