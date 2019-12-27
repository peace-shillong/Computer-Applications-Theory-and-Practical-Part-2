%{
	int wcount =0;
	int lcount =0;
	int count =0;
%}
word [^\t\n]+
line [\n]
char .
%%
{word} {wcount++;
	count +=yyleng ; }
{line} {lcount ++; count++ ; }
{char} {count++ ; }
%%
void main()
{
	yylex();
	printf("%d %d %d ",wcount,lcount,count);
}

