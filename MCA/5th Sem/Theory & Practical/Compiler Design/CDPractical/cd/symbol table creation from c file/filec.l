%{
	/*flex program to extact tokens from a source file.
	the tokens are then stored in a symbol table text file
	the structure to be stored per line is : token code line number*/
	FILE *fp;
	int line = 1;
%}
keyword if|else|while|switch|for
%%
{keyword} {fprintf(fp,"%s\t%s\t%d\n",yytext,"KEYWORD",line);ECHO;}
[\+\-\%\*/] {fprintf(fp,"%s\t%s\t%d\n",yytext,"OPERATOR",line);ECHO;}
\n {line++;ECHO;} 
. {ECHO;}
%%
void main()
{
	char file[30];
	printf("\n\tEnter the source file name:");
	scanf("%s",&file);
	fp = fopen("mysymbol.txt","a");
	yyin = fopen(file,"r");
	yylex();
	fclose(fp);
}
