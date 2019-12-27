SET SERVEROUTPUT ON
DECLARE 
  NOD NUMBER:=0;
  NOL NUMBER:=0;
BEGIN 
select COUNT(CITY)into NOL
from locations;
select COUNT(departmentname)into NOD
From departments;
DBMS_OUTPUT.PUT_LINE('Number of Locations '|| NOL);
DBMS_OUTPUT.PUT_LINE('Number of Departments ' || NOD);

END;
