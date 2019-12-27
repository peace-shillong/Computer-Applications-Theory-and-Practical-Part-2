%{
	/*Flex Program to extract tokens from a source file.
	  the tokens are then stored in a symbol table text file
	  the structure to be stored perline: token code linenumber*/
		FILE *fp;
		int lno=1;
%}
keyword if|else|while|switch|for
%%
{keyword} { fprintf(fp,"\n %s %s exists in line number : %d\n",yytext,"KEYWORD",lno); ECHO; }
[\+\-\*%/] { fprintf(fp,"\n %s %s exists in line number : %d\n",yytext,"OPERATOR",lno); ECHO; }
[\n] { lno++; ECHO; }
. { ECHO; } 
%%
void main()
{
	char filename[30];
	printf("\n Enter the source filename : ");
	scanf("%s",&filename);
	fp=fopen("symbol_table.txt","w");
	yyin=fopen(filename,"r");//or "source_file.c" yyin - reading from another file if reading from console
	yylex();
	fclose(fp);
}
