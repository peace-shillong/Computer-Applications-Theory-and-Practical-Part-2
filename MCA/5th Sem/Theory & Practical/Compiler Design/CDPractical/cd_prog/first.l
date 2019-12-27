%{
	char name[20];
	// My first Lex Program
%}
%%
\n	 {printf("%s is absent",name);}
%%
void main()
{
	printf("Enter your name :");
	scanf("%s",name);
	yylex();
}


