%{
        #include<stdio.h>
        int count = 0;
%}
%%
[A-z\-]+ {count = count+1;}
%%
void main()
{
        yyin = fopen("file1.txt","r");
        yylex();
        printf("\n\tNumber of words in the file are %d\n\t",count);
        fclose(yyin);
}

