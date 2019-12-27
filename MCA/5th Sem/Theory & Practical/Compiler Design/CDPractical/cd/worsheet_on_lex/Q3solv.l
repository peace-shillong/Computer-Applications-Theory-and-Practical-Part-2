%{
        #include<stdio.h>
        int words = 0;
        int lines = 0;
        int ch = 0;
        int chws = 0;
%}
%%
[A-z\-]+ {words = words+1;chws = ch += yyleng;}
\n {lines = lines+1;}
" " {chws = chws+1;}
%%
void main()
{
        yyin = fopen("file1.txt","r");
        yylex();
        printf("\n\tNumber of word %d\n\n\tNumber of lines %d\n\n\tNumber of characters %d\n\n\tNumber of charcters without space %d\n\n",words,lines,ch,chws);
}

