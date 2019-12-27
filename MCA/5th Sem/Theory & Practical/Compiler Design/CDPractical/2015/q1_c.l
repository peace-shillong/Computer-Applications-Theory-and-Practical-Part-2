%{

%}
str (abb)[a-z A-Z]*(ccd)
%%
{str} printf("\n accepted");
.* printf("\n rejected");
%%
main()
{
printf("Enter the string:");
yylex();
}

