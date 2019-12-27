%{
	//program to identify numbers,keywords,identifier and write in files
	#include<stdio.h>
	FILE *fp;
%}
%%
[0-9]+\n {
		fp=fopen("nki_list.txt","a");
		fprintf(fp,"\nNumber = %s\n",yytext);
	}
[if|else|while|for|end]	{
	
		fp=fopen("nki_list.txt","a");
		fprintf(fp,"\nKeyword = %s\n",yytext);
	}
[A-z]+[a-z]*[0-9]*[_]* {
		fp=fopen("nki_list.txt","a");
		fprintf(fp,"\nIdentifier = %s\n",yytext);
	}

%%
main()
{
	printf("\n\t Enter any words : ");
	yylex();
	fclose(fp);
}
