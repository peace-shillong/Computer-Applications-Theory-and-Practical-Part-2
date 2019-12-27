SET SERVEROUTPUT ON
DECLARE
  
  jobid varchar(10);
BEGIN 
select jobid into jobid
from employees e
where e.lastname='Syiem';

if jobid='Manager' then
  DBMS_OUTPUT.PUT_LINE('Hold meeting with your employees');
elsif jobid='Clerk' then
  DBMS_OUTPUT.PUT_LINE('Meet your Manager');
elsif jobid='Accountant' then
  DBMS_OUTPUT.PUT_LINE('Prepare balance sheet by tomorrow');
end if;

END;