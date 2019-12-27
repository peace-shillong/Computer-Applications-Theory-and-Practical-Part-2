set serveroutput on
BEGIN
  update employees
  set salary=salary +(salary*0.1);
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
  commit;  
EXCEPTION
  When value_error then  
    DBMS_OUTPUT.PUT_LINE('Invalid Type');
  When no_data_found then  
    DBMS_OUTPUT.PUT_LINE('No data : '||SQLERRM);
  When others then
      DBMS_OUTPUT.PUT_LINE(SQLCODE ||' '||SQLERRM);
END;