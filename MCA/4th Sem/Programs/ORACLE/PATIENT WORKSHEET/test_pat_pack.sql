set serveroutput on;
declare 
  cost number;
begin
--  pat_pack.list_patient;
--  pat_pack.list_by_city;
  cost:=pat_pack.getcost('abc');
  dbms_output.put_line('Cost is '||cost);
end;