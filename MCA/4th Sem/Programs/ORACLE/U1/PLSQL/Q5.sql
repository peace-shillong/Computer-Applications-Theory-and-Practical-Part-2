SET SERVEROUTPUT ON
DECLARE 
  fn VARCHAR(30);
  ln VARCHAR(30);
  Dn VARCHAR(30);
BEGIN 
select INITCAP(FIRSTNAME),INITCAP(LASTNAME),Departmentname into fn,ln,Dn
from employees e, departments d
WHERE EMPLOYEEID=20 AND e.departmentid=d.departmentid;

DBMS_OUTPUT.PUT_LINE('FIRST NAME ' || fn);
DBMS_OUTPUT.PUT_LINE('LAST NAME ' || ln);
DBMS_OUTPUT.PUT_LINE('Department ' || Dn);
END;