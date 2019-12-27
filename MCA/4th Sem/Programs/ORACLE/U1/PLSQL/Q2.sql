SET SERVEROUTPUT ON
DECLARE 
  sum_sal NUMBER;
  avg_sal NUMBER;
BEGIN 
select SUM(Salary),AVG(Salary) into sum_sal,avg_sal 
from employees
WHERE Jobid = 'Manager';
DBMS_OUTPUT.PUT_LINE('Sum of Salary' || sum_sal);
DBMS_OUTPUT.PUT_LINE('Average of Salary' || avg_sal);
END;