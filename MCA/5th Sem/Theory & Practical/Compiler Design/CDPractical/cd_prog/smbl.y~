%{
	#include<stdio.h>
	double vbtable[25]
%}
union{
	double dval;
	int vblno;
	}
%token <vblno> NAME 
%token <dval>NUMBER
stmt:NAME '=' expr {vbtable[$1]=$3}
