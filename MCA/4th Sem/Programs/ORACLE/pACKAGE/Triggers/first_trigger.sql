create or replace trigger first_trigger
before insert on locations
for each row
begin
  dbms_output.put_line('Trigger Fired');
  dbms_output.put_line('User Name: '||user);
  dbms_output.put_line ('Date: '||sysdate());
  dbms_output.put_line('Insertion on Locations Table was done');
  dbms_output.put_line('Record inserted: '||:new.locationId);
end;
  
  