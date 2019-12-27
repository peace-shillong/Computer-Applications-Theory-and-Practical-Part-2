%{
	/*
		Lex Program to create a symbol table:
		Structure: Token Code LineNo
	*/
	FILE *fp;
	int lineNo=1;
%}

keyword if|else|switch|while|for

%%
{keyword} { fprintf(fp,"%s %s %d\n",yytext, "KEYWORD", lineNo);}
[+\-%*/] { fprintf(fp,"%s %s %d\n",yytext, "OPERATOR", lineNo);}
\n { lineNo++; }
. { }
%%
main()
{	
	char filename[30];
	printf("\nEnter C source filename: ");
	scanf("%s",filename);
	fp=fopen("symbol_table","w");
	yyin=fopen(filename,"r");
	yylex();
	fclose(fp);		
} 

