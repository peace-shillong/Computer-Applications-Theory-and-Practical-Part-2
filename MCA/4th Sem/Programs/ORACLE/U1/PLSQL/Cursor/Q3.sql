set serveroutput on
DECLARE 
  CURSOR c is Select employeeid,firstname,departmentname from employees e, departments d
  where e.departmentid=d.departmentid and e.salary>=15000;
  c_rec c%ROWTYPE;
BEGIN
  FOR c_rec in c LOOP   
    DBMS_OUTPUT.PUT_LINE('Employee id '||c_rec.employeeid);
    DBMS_OUTPUT.PUT_LINE('First Name: '||c_rec.firstname);
    DBMS_OUTPUT.PUT_LINE('Employee Department '||c_rec.departmentname);
    DBMS_OUTPUT.PUT_LINE('----------------');
  END LOOP;
 
EXCEPTION
  When value_error then  
    DBMS_OUTPUT.PUT_LINE('Invalid Type');
  When no_data_found then  
    DBMS_OUTPUT.PUT_LINE('No data : '||SQLERRM);
  When others then
      DBMS_OUTPUT.PUT_LINE(SQLCODE ||' '||SQLERRM);
END;