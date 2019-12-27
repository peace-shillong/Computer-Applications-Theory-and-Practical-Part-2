set serveroutput on
declare 
  r1 employees%ROWTYPE;
BEGIN
  select * INTO r1 from employees;
  DBMS_OUTPUT.PUT_LINE('Employee : '||r1.employeeid||' '||r1.firstname);
  if(SQL%ISOPEN) then
    DBMS_OUTPUT.PUT_LINE('CURSOR OPEN');
  else
    DBMS_OUTPUT.PUT_LINE('CURSOR CLOSED');
  End if;  
    DBMS_OUTPUT.PUT_LINE('Number of rows affected '|| SQL%ROWCOUNT);
  if(SQL%FOUND) then
    DBMS_OUTPUT.PUT_LINE('ROWS FOUND');
  else
    DBMS_OUTPUT.PUT_LINE('ROWS NOT FOUND');
  End if;  
EXCEPTION
  When value_error then  
    DBMS_OUTPUT.PUT_LINE('Invalid Type');
  When too_many_rows then  
    DBMS_OUTPUT.PUT_LINE('Multiple Rows Selected. ');
  When others then
    DBMS_OUTPUT.PUT_LINE(SQLCODE ||' '||SQLERRM);
END;