%{
	#include<stdio.h>
	FILE *fp;
%}
%%
if|else|for|while|do {fprintf(fp,"Keyword : %s\n",yytext);}
[0-9]+ {fprintf(fp,"Number : %s\n",yytext);}
[A-z][A-z0-9_]+ {fprintf(fp,"Identifier :%s\n",yytext);}
.* {printf("Not in the list");}

%%
void main()
{
	fp=fopen("nki_list.txt","a");
	yylex();
	fclose(fp);
}
