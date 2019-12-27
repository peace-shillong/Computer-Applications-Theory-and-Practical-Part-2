%{
	#include<stdio.h>
	FILE *fp;
	char word[100];
%}
%%
[a-z]+ {fp = fopen("mysymbol.txt","r");
	while(!feof(fp)
	{
		fscanf(fp,"%s",&word);
		
	}}
%%
void main()
{
}
