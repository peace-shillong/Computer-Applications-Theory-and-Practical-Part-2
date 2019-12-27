set serveroutput on
DECLARE 
  Cursor c is Select max(salary) as maxsal,min(salary) minsal,d.departmentid from employees e, departments d
  where e.departmentid=d.departmentid
  group by d.departmentid;
  c1 c% ROWTYPE;
BEGIN
  FOR c1 IN c LOOP
   DBMS_OUTPUT.PUT_LINE('Maximum salary is '|| c1.departmentid);
   DBMS_OUTPUT.PUT_LINE('Maximum salary is '|| c1.maxsal);
   DBMS_OUTPUT.PUT_LINE('MInimum salary is '|| C1.minsal);
   END LOOP;
EXCEPTION
  When value_error then  
    DBMS_OUTPUT.PUT_LINE('Invalid Type');
  When no_data_found then  
    DBMS_OUTPUT.PUT_LINE('No data : '||SQLERRM);
  When others then
      DBMS_OUTPUT.PUT_LINE(SQLCODE ||' '||SQLERRM);
END;