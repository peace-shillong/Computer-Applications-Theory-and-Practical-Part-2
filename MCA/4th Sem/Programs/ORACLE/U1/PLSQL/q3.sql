SET SERVEROUTPUT ON
DECLARE 
  fn VARCHAR(30);
  ln VARCHAR(30);
  hd VARCHAR(30);
  Dn VARCHAR(30);
BEGIN 
select INITCAP(FIRSTNAME),INITCAP(LASTNAME),HIREDATE,UPPER(Departmentname) into fn,ln,hd,Dn
from employees e, departments d
WHERE EMPLOYEEID=30 AND e.departmentid=d.departmentid;

DBMS_OUTPUT.PUT_LINE('FULL NAME ' || fn || ' ' || ln);
DBMS_OUTPUT.PUT_LINE('HIREDATE ' || hd);
DBMS_OUTPUT.PUT_LINE('Department ' || Dn);
END;
