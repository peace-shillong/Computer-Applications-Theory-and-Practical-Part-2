%{
#include<stdio.h>
#include<ctype.h>
int k;
int c=0,w=0,l=0,s=0;
void display(char *);
%}
letter [a-z]
com [//]
%%
{com} {k=1;}
{letter} {if(k==1) display(yytext);}
" "	{s++;c++;}
[\n]	{l++;c++;}
[^\n\t]+	{w++;c+=yyleng;}
%%
main()
{printf("*****Please!Enter String*****");
 
printf("Chars=%d\nSpaces=%d\nLines=%d\nWord=%d\n",c,s,l,w);
yylex();
}
 void display(char *s)
{
 int i;
 for(i=0;s[i]!='\0';i++)
 printf("%c", toupper(s[i]));
}
int yywrap()
{
return 1;
}
