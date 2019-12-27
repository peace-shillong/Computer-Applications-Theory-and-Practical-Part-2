-- A Trigger for displaying a message whenever a record is deleted 

create or replace trigger trigger_contacts_del
After delete or update on contacts
for each row
begin
  DBMS_OUTPUT.PUT_LINE('Record Deleted with id :'||:old.contactid);
  DBMS_OUTPUT.PUT_LINE('USERNAME :'||USER);
  DBMS_OUTPUT.PUT_LINE('DATE :'||SYSDATE);
End;