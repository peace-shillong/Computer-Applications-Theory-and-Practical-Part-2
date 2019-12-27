set serveroutput on
DECLARE 
  CURSOR c is Select city from employees e, departments d,locations l
  where e.departmentid=d.departmentid and d.locationid=l.locationid and city='Shillong';
  c_rec c%ROWTYPE;
  counter number;
BEGIN
  counter:=0;
  FOR c_rec in c LOOP   
    counter:=counter+1;  
  END LOOP;
     DBMS_OUTPUT.PUT_LINE('Total Employees in Shillong is '|| counter);
  if SQL%FOUND then
    dbms_output.put_line(SQL%ROWCOUNT);
  end if;
    
EXCEPTION
  When value_error then  
    DBMS_OUTPUT.PUT_LINE('Invalid Type');
  When no_data_found then  
    DBMS_OUTPUT.PUT_LINE('No data : '||SQLERRM);
  When others then
      DBMS_OUTPUT.PUT_LINE(SQLCODE ||' '||SQLERRM);
END;