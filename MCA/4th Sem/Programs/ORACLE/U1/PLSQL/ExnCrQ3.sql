set serveroutput on
declare
Begin
  insert into locations (locationid,city) values(70,'Delhi');
    DBMS_OUTPUT.PUT_LINE('Number of rows affected '||SQL%ROWCOUNT);
  insert into locations (locationid,city) values(60,'Pune');
  DBMS_OUTPUT.PUT_LINE('Number of rows affected '||SQL%ROWCOUNT);
    
  
  delete from locations where locationid=60 or locationid=70;
   
EXCEPTION
  When value_error then  
    DBMS_OUTPUT.PUT_LINE('Invalid Type');
  When dup_val_on_index then  
    DBMS_OUTPUT.PUT_LINE('Duplicate values');
  When others then
    DBMS_OUTPUT.PUT_LINE(SQLCODE ||' '||SQLERRM);
END;