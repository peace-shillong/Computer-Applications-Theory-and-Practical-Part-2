%{
	#include<stdio.h>
	FILE *fp;
%}
%%
if|else|for|while|do {fprintf(fp,"Keyword : %s\n",yytext);}
[0-9]+\.[0-9]+[e|E]?[0-9]+ {fprintf(fp,"Decimal : %s\n",yytext);}
[A-z][A-z0-9_]+ {fprintf(fp,"Identifier :%s\n",yytext);}
"//".* {fprintf(fp,"Comments :%s\n",yytext);}
.* {printf("Not in the list");}

%%
void main()
{
	fp=fopen("check.txt","a");
	yylex();
	fclose(fp);
}
