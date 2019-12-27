--calling the function gr_3nos
set serveroutput on
declare 
  res number;
begin 
  res:=gr_3nosfn(1,1,21);
  if res=-1 then
  DBMS_OUTPUT.PUT_LINE('Equal');
  else
  DBMS_OUTPUT.PUT_LINE(res);
  end if;
end;