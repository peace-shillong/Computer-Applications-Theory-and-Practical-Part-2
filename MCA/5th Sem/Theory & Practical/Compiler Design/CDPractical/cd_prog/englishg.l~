%{
	#include<stdio.h>
%}
%%
[\t ]
boy |
girl |
children |
car |
toys |
college |
Grace |
Saphi |
Daia |
Fairly	{printf("\n%s is a noun",yytext);}

is |
are |
am |
was |
were |
has |
have |
had |
will |
shall |
would |
could |
should |
been |
did |
done |
go |
goes |
went |
gone |
play |
going |
dance |
sleep |
sing |
sits	{printf("\n%s is a verb",yytext);}

silently |
quietly {printf("\n%s is an adverb",yytext);}

in |
at |
on |
to |
under |
above |
below |
behind {printf("\n%s is a preposition",yytext);}

and |
but |
then |
or {printf("\n%s is a conjunctive",yytext);}

these |
those |
this |
long |
short |
tall {printf("\n%s is an adjective",yytext);}

I |
he |
she |
it |
they |
we |
you {printf("\n%s is a pronoun",yytext);}

[a-zA-Z]+ {printf("\n%s is not recognize",yytext);}
.|\n	{ECHO;}
%%
main()
{
	yylex();
}
