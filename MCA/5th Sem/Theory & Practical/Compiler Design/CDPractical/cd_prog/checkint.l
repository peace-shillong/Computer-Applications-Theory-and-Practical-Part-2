%{
	//program to recognized if a number is an integer
%}
int [+|-]?[1-9]+
%%
{int} {printf("\nIt is an integer");}
[0] {printf("\n0 is an integer");}
[+|-]?[0] {printf("\n0 does not have a sign.");}
%%
void main()
{
	yylex();
}
