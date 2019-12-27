%{

%}
%%
[\t ] 
is |
am |
are |
were |
was |
be |
being |
been |
do |
does |
did |
will |
would |
should |
can |
could |
has |
have |
had |
go	{ printf("%s: is a verb\n", yytext); }

very |
simply |
gently |
quitely |
calmly |
angrily	{ printf("%s: is an adverb\n", yytext); }

to |
from |
behind |
above |
below |
between	{ printf("%s: is a preposition\n", yytext); }

then |
and |
but |
or	{ printf("%s: is a conjunction\n", yytext); }

their |
my |
your |
his |
her |
its	{ printf("%s: is an adjective\n", yytext); }

I |
you |
he |
she |
we |
they	{ printf("%s: is a pronoun\n", yytext); }

john |
mary |
james |
susan |
edmond |
peter	{ printf("%s: is a noun\n", yytext); }

[a-zA-Z]+ {
	printf("%s: don't recognize\n", yytext);
	}
.|\n	{ ECHO; }
%%
main()
{
	yylex();
}
			

