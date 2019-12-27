create or replace trigger contacts_tri
before insert or update on contacts
for each row
declare 
  pid log_contacts.log_id %TYPE;
  dt log_contacts.log_dt %TYPE;
  op log_contacts.operation_id %TYPE;
  username log_contacts.username %TYPE;
  rid log_contacts.record_id %TYPE;
begin 
    dbms_output.put_line('Trigger Fired');
    dbms_output.put_line('User Name: '||user);
    dbms_output.put_line('Date: '||sysdate);
    --pid:=seq.nextval; doesnt work
    if inserting then
      dbms_output.put_line('Insertion on Contacts Table was done');
      --dbms_output.put_line('Record Added '||:new.contactid);
      insert into log_contacts Values(seq.nextval,sysdate,'INSERT',user,:new.contactid);
    else
      dbms_output.put_line('Update on Contacts Table was done');
     -- dbms_output.put_line('Record Updated '||:old.contactid);
     insert into log_contacts Values(seq.nextval,sysdate,'UPDATE',user,:old.contactid);
    end if;
end;
   