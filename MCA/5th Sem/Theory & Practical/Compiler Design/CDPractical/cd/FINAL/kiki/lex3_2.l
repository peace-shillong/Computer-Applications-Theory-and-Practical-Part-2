%{
	/*program to display the number of characters*/
	int total=0;
%}

%%
.+[\n] { printf("\n %s \n Character count = %d \n",yytext,yyleng);
	total = total+yyleng; }


%%

void main()
{
	yyin=fopen("hello.txt","r");
	yylex();
	printf("\nTotal=%d \n",total);
	fclose(yyin);
}
 
