%{
#include<stdio.h>
int count=0;
%}
%%
"/*"[A-Za-z0-9\t\n;,!()%#*&+=/><"_-]*"*/" { count++; fprintf(yyout,"");}
"//".* { count++; fprintf(yyout,"");}
%%
void main()
{
	yyin=fopen("existing.c","r");  
	yylex();
	printf("Number of Comments=%d\n",count);
}
