%{
	/*program to read from symbol table and validate the inputed symbol*/
	#include<stdio.h>

	FILE *fp;
	char word[20];//coming from table
	int result;//store comparision result
	int found = 0;
%}
%%
[a-z]+ {
	fp = fopen("symboltable.txt","r");//fp gets refreshed every time when user enters a word(it will check from the top of the table)
	found = 0;
	while(!feof(fp))
	{
		fscanf(fp,"%s",word);
		result = strcmp(yytext,word);
		if(result==0)
		{
			printf("\n\t%s is a reserved word..\n\t",yytext);
			found = 1;
			break;
			
		}
	}if(found == 0)
	{
		printf("\n\tNot a reserved word:");
	}}
.* {printf("\n\tNot a word");}	
%%
void main()
{
	yylex();
	fclose(fp);
	//compare yytext and symbole from table
	//yytext stores users input
}
