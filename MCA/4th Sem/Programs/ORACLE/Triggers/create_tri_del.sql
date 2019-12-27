-- A Trigger for displaying a message whenever a record is deleted 

create or replace trigger trigger_contacts_del
After delete on contacts
for each row
begin
  DBMS_OUTPUT.PUT_LINE('Record Deleted');
End;