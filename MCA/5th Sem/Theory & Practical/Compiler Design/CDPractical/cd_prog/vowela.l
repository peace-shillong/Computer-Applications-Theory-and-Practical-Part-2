%{
%}
word [^\t\n][^0-9]
vowela [a|A]
%%
{vowela}{word}+{vowela} {printf("It has a vowel a in the front and end ");}
[^vowela]{word}+[^vowela] {printf("It does not have a in front and end ");}
%%
void main()
{
	yylex();
	printf(" Enter any string :");
}
