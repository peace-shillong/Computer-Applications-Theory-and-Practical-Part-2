%{
#include<stdio.h>

	char * toUp(char *); 
%}
%%
[\/]{2}[a-z]+ {printf("%s",toUp(yytext));}
%%

void main()
{
        yylex();
}
char * toUp(char *s)
{
	int i=0;
	for(i=2;i<yyleng;i++)
	{
		s[i]=s[i]-32;
	}
	return s;
}

