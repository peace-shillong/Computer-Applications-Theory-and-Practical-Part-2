-- calling package elements
set serveroutput on
declare 
  result number;
begin

  firstpackage.smallest_3nos(12,23,10);
  
  DBMS_OUTPUT.PUT_LINE('Smallest is '||firstpackage.smallest_3nos_func(101,12,23));
  result:=firstpackage.smallest_3nos_func(12,2,2);
  if result=-1 then
    DBMS_OUTPUT.PUT_LINE('The Numbers are equal');
  else
    DBMS_OUTPUT.PUT_LINE('Smallest is '||result);
   end if;
end;
