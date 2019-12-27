%{
	/*program to read from a file and display its content one line at a time.Each line should begin with a line number*/
	int lineno = 0;
%}
%%
.+\n {printf("%d. %s",++lineno,yytext);}
%%
void main()
{
	/*char str[100];
	printf("\nEnter a file name:\t");
	scanf("%s",&str);*/
	yyin = fopen("file1.txt","r");
	yylex();
	fclose(yyin);
}
