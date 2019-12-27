set serveroutput on
DECLARE 
  CURSOR c is Select employeeid,firstname,salary,hiredate from employees 
  Order by salary;
  fname employees.firstname %TYPE;
  eid employees.employeeid %TYPE;
  sal employees.salary %TYPE;
  hdate employees.hiredate %TYPE;
BEGIN
  OPEN c;
  LOOP
    FETCH c INTO eid,fname,sal,hdate;
    EXIT WHEN c%NOTFOUND;
    DBMS_OUTPUT.PUT_LINE('Employee id '||eid);
    DBMS_OUTPUT.PUT_LINE('First Name: '||fname);
    DBMS_OUTPUT.PUT_LINE('Employee Salary '||sal);
    DBMS_OUTPUT.PUT_LINE('Employee Hire Date '||hdate);
    DBMS_OUTPUT.PUT_LINE('----------------');
  END LOOP;
  CLOSE c;
  
EXCEPTION
  When value_error then  
    DBMS_OUTPUT.PUT_LINE('Invalid Type');
  When no_data_found then  
    DBMS_OUTPUT.PUT_LINE('No data : '||SQLERRM);
  When others then
      DBMS_OUTPUT.PUT_LINE(SQLCODE ||' '||SQLERRM);
END;