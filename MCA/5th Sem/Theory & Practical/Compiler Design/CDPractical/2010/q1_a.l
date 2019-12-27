%{
        
          FILE *fp;
          int lno=1;
%}
reserved_word if|then|else|end|do|while|read|write
%%
{reserved_word} { 
			printf("%s %s %d\n",yytext,"RESERVED WORD",lno);
		 	ECHO;
	   	}
[\+\-\*/><|);]|[:][=] {
		 	 
			printf("%s %s %d\n",yytext,"SPECIAL SYMBOL",lno);
		 	ECHO;
	   	 }
[0-9]+|[\+\-][0-9]+\.[0-9]+E[\+\-][0-9]+|[A-z]+([A-z]|[0-9]|_)* {
							 
							printf("%s %s %d",yytext,"OTHERS",lno);
							ECHO;
						}
[{].+[}] {
		 
		printf("%s %s %d",yytext,"OTHERS",lno);
	 }
[\n] {
     	lno++;
	ECHO;
     }
. {
	 ECHO;
  }
%%
void main()
{
        
        printf("\n Enter Something : ");
        
        yylex();
         
        return;
}






