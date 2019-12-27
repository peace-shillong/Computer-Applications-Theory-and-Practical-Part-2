SET SERVEROUTPUT ON
DECLARE
  dId number;lId number;
  city varchar(10);
BEGIN 
/*select departmentid into dId 
from employees
WHERE employeeid = 20;
select locationid into lId 
from departments
WHERE departmentid = dId;
select city into city 
from locations
WHERE locationid = lId;
*/
select city into city
from employees e,departments d,locations l
where e.employeeid=20 and l.locationid=d.locationid and e.departmentid=d.departmentid;
if city='Shillong' then
  DBMS_OUTPUT.PUT_LINE('It is a reminder for tomorrow''s meeting');
else
  DBMS_OUTPUT.PUT_LINE('It is a reminder for today’s meeting');
end if;

END;