set serveroutput on
DECLARE 
  CURSOR c is Select employeeid,firstname,salary,hiredate from employees 
  Order by salary;
  c_rec c%ROWTYPE;
BEGIN
  FOR c_rec in c LOOP   
    DBMS_OUTPUT.PUT_LINE('Employee id '||c_rec.employeeid);
    DBMS_OUTPUT.PUT_LINE('First Name: '||c_rec.firstname);
    DBMS_OUTPUT.PUT_LINE('Employee Salary '||c_rec.salary);
    DBMS_OUTPUT.PUT_LINE('Employee Hire Date '||c_rec.hiredate);
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