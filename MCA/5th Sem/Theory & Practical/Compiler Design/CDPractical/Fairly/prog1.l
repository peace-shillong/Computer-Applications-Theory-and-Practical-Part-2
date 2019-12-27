%{
	//welcome
	char name[10];
%}
%%
\n	{printf("Good Morning %s",name);}
%%
void main()
{
	printf("Enter your name: ");
	scanf("%s",&name);
	yylex();
}

