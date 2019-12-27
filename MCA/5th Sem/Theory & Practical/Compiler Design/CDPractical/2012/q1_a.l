%{
	
	#include<stdio.h>
	FILE *fp;
               char word[20];
	int result,found=0;
%}
%%
[a-z]+ { 
	fp=fopen("Symbol_table.txt","r"); 
	found=0;
	while(!feof(fp))
	 {
		 fscanf(fp,"%s",word);
		 result=strcmp(yytext,word); 
		if(result==0)
		{
		
			 printf("\nReserved word %s \n",yytext);
			 found=1;
		 	 break;
		}
	
		
	 }
	if(found==0)
		printf("It is not a reserved word");

	}
.+ { printf("\n Not A reserved word \n"); }
 %%
void main()
{            yylex();
	fclose(fp);
}


