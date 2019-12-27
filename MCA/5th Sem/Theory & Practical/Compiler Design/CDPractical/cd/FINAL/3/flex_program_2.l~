%{
	//Program to create a File:Symbol Table that will store any valid identifier or arithmetic operator entered
	FILE *fp;
%}
%%
[a-z_]+ {
		fp=fopen("token_file.txt","a");
		fprintf(fp,"\n%s",yytext);
	}
[\+\-\*/%] {
		 fp=fopen("token_file.txt","a");
                fprintf(fp,"\n%s",yytext);
           } 
[+]{2} {
		fp=fopen("token_file.txt","a");
                fprintf(fp,"\n%s",yytext);
        }
[-]{2} {
                fp=fopen("token_file.txt","a");
                fprintf(fp,"\n%s",yytext);
	}
[/]{2}[ A-Za-z0-9_]+ {
			fp=fopen("token_file.txt","a");
			fprintf(fp,"\n%s",yytext);
                     }
[/][\*][ A-z0-9_,;.\n]*[\*][/] {
		                fp=fopen("token_file.txt","a");
                		fprintf(fp,"\n%s",yytext);
          		}
%%
void main()
{
	yylex();
	fclose(fp);
}
