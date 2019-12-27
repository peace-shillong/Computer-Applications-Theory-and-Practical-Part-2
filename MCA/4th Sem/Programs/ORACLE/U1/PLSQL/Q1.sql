SET SERVEROUTPUT ON
DECLARE 
  fname VARCHAR(30);
  lname VARCHAR(30);
BEGIN 
select FIRSTNAME,LASTNAME into fname,lname 
from employees
WHERE employeeid = 10;
DBMS_OUTPUT.PUT_LINE('First Name' || fname);
DBMS_OUTPUT.PUT_LINE('Last Name' || lname);
END;