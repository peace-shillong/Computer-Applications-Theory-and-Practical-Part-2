set serveroutput on
declare 
   CURSOR c IS Select * from log_contacts;
  c1 log_contacts %rowtype;
begin
  dbms_output.put_line('LOG ID   -   DATE   -   OPERATION   -  USER   -   RECORD ID');
  for c1 in c loop
    dbms_output.put_line(c1.log_id || '    -   ' || c1.log_dt  || '   -   ' || c1.operation_id  || '   -   ' || c1.username  || '   -   ' || c1.record_id);
  end loop;
  
end;