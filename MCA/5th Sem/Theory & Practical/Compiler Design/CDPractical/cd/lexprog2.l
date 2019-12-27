%{
	/*program to display the number of characters at the end of the file + contents + number of characters per line*/
	int total = 0;
%}
%%
.+\n {printf("\n\t%s\n\tcharacters : %d\n",yytext,yyleng);
	total = total + yyleng;
	}
%%
void main()
{
	yyin = fopen("file1.txt","r");
	total = total + yyleng;
	yylex();
	printf("\n\tTotal characters are : \t %d\n\n\t",total);
	fclose(yyin); 
}
