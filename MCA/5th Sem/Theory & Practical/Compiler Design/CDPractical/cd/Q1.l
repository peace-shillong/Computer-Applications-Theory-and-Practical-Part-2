%{
	FILE *fp;
	int lno=1;	
%}
keyword if|then|else|end|do|while|read|write
%%
{keyword} { 
		fprintf(fp,"\n %s %s %d \n",yytext,"KEYWORD",lno);
		ECHO;
	  }
[\+\-\*%/] {
				 fprintf(fp,"\n %s %s %d \n",yytext,"OP",lno); 
				 ECHO;
			}
[0-9]+  { 
		fprintf(fp,"\n %s %s ",yytext,"INTEGER"); 
		ECHO;
	}
[\+\-][0-9]+\.E[\+\-][0-9]+ {
						 fprintf(fp,"\n %s %s ",yytext,"FLOATING POINT"); 
						 ECHO;
				      }
[a-zA-Z0-9_]+ { 
			fprintf(fp,"\n %s %s",yytext,"IDENTIFIER"); 
			ECHO;
		}
[{]{1}.+[}]{1} { 
			fprintf(fp,"\n %s %s",yytext,"COMMENT"); 
		  } 
\n { lno++; }
. { ECHO; }
%%
void main()
{
	char fname[30];
	printf("\n Enter the source filename :");
	scanf("%s",fname);
	fp=fopen("symbol_table.txt","w");
	yyin=fopen(fname,"r");
	yylex();
	fclose(fp);
	return;
}
