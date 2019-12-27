create or replace trigger third_trigger
before insert on locations
for each row
begin
  insert into log_table values(seq.nextval,user,sysdate,'Insertion into locations',:new.locationId);
end;
 