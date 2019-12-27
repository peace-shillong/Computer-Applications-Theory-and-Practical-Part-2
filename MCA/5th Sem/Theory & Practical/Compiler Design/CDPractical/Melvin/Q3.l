%{
#include <stdio.h>
#include <string.h>
int ch;
char expx[100];
char aa[100];
char bb[100];
int i,oprn,oprnn;
int flag=0;
char opt;
char cc='9';
%}

test [0-9]+[\+|\-|\*|\/][0-9]+
%option noyywrap
%%
{test} {
	strcpy(expx,yytext);
	for(i=0;i<yyleng;i++)
	{
		if(expx[i]>='0' && expx[i]<='9')
		{
			aa[0]=expx[i];
			strcat(bb,aa);		
		}
		else
		{
			opt=expx[i];
			oprn=atoi(bb);
			strcpy(bb,"");		
		}
	}
	oprnn=atoi(bb);
	flag=0;
	strcpy(bb,"");
	if(opt=='+')
		printf("%d",oprn+oprnn);
	else
	if(opt=='-')
		printf("%d",oprn-oprnn);
	else
	if(opt=='*')
		 printf("%d",oprn*oprnn);
	else
	if(opt=='/')
		 printf("%d",oprn/oprnn);
	
  }

%%

void main()
{
        yylex();
}
