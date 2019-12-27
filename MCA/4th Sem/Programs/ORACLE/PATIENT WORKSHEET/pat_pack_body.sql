create or replace package body pat_pack is 
  Cursor c is select * from patient;
  Cursor c1 is select * from patient group by city,patient_id,first_name,last_name,dob;
  c_row c %rowtype;
  t_cost treatment.treatment_cost %type;

  procedure list_patient is
  begin
    for c_row in c loop
      dbms_output.put_line('ID'||c_row.patient_id);
      dbms_output.put_line('First Name'||c_row.first_name);
      dbms_output.put_line('Last Name'||c_row.last_name);
      dbms_output.put_line('DOB'||c_row.dob);
      dbms_output.put_line('City'||c_row.city);
    end loop;
  end;
  procedure list_by_city is
  begin 
    for c_row in c1 loop
      dbms_output.put_line('ID'||c_row.patient_id);
      dbms_output.put_line('First Name'||c_row.first_name);
      dbms_output.put_line('Last Name'||c_row.last_name);
      dbms_output.put_line('DOB'||c_row.dob);
      dbms_output.put_line('City'||c_row.city);
    end loop;  
  end;
  function getcost(t_name in varchar2) return number is
  begin 
    select treatment_cost into t_cost from treatment where treatment_name=t_name;
    --dbms_output.put_line('Cost of '||t_name||' is '||t_cost);
    return t_cost;
  end;
end pat_pack;