%{
        /*Flex Program to extract tokens from a source file.
          the tokens are then stored in a symbol table text file
          the structure to be stored perline: token code linenumber*/
          FILE *fp;
          int lno=1;
%}
reserved_word if|then|else|end|do|while|read|write
%%
{reserved_word} {
		 	fprintf(fp,"%s\t%s\t%d\n",yytext,"RESERVED WORD",lno);
		 	ECHO;
	   	}
[\+\-\*/><|);]|[:][=] {
		 	fprintf(fp,"%s\t%s\t%d\n",yytext,"SPECIAL SYMBOL",lno);
		 	ECHO;
	   	 }
[0-9]+|[\+\-][0-9]+\.[0-9]+E[\+\-][0-9]+|[A-z]+([A-z]|[0-9]|_)* {
							fprintf(fp,"%s\t%s\t%d\n",yytext,"OTHERS",lno);
							ECHO;
						}
[{].+[}] {
		fprintf(fp,"%s\t%s\t%d\n",yytext,"OTHERS",lno);
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
        char filename[30];
        printf("\n Enter the source filename : ");
        scanf("%s",filename);
        fp=fopen("Symbol_table.txt","w");
        yyin=fopen(filename,"r");
        yylex();
        fclose(fp);
        return;
}
                                                                                         
                                                                                                                                          
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                              
                                                                                                                                          
                                                                                                                                              

