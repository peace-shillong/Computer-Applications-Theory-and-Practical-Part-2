%{
        //yacc prog to add integers
        #include<stdio.h>
%}
%token NUM
%left '+' '-'
%left '*' '/'
%%
stmt: expr '\n' {
                        printf("\n\tresult = %d\n\t",$1);//$1 holds result when hit \n
                        return;
 }
expr: expr '*' expr {$$ = $1*$3;}
        | expr '/' expr {$$ = $1/$3;}
        | NUM {$$=$1;}
        | expr '+' expr {$$ = $1+$3;}
        | expr '-' expr {$$ = $1-$3;}
%%
void main()
{
        printf("\n\tEnter arithmetic expression with operators +,-, and *:");
        yyparse();
}
void yyerror()
{
        printf("\n\tError...Input formate is wromg!");
        return;
}

