%{
  #include<stdio.h>
  #include"y.tab.h"
%}
%%
[\t]*{return B;}
[=][=]|[<][=]|[>][=]|[>|[>]|[!][=] {}
