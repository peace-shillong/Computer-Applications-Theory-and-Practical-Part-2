create or replace trigger second_trigger
after delete or update on locations 
for each row
begin
    dbms_output.put_line('Trigger Fired');
    dbms_output.put_line('User Name: '||user);
    dbms_output.put_line('Date: '||sysdate());
    if(deleting) then
      dbms_output.put_line('Deltion on Locations Table was done');
      dbms_output.put_line('Record Deleted '||:old.locationId);
    else
      dbms_output.put_line('Update on Locations Table was done');
      dbms_output.put_line('Record Update '||:old.locationId);
    end if;
end;
   
    