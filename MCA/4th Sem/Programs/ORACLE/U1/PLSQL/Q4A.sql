SET SERVEROUTPUT ON
DECLARE 
  NOD NUMBER:=0;
  NOL NUMBER:=0;
BEGIN 
select COUNT(distinct Locationid), COUNT(departmentname)into NOL,NOD
From departments;
DBMS_OUTPUT.PUT_LINE('Number of Locations '|| NOL);
DBMS_OUTPUT.PUT_LINE('Number of Departments ' || NOD);

END;