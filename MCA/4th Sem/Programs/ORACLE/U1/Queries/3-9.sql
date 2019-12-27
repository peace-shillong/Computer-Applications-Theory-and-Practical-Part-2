/*Select Distinct JOBID from employees;*/
SELECT firstName||' '||lastName as "Employee Names" 
From employees;
SELECT employeeid||','||firstName||','||lastName||','||email||','||phoneno||','||hiredate||','||commision_pct||','||jobid||','||managerid||','||departmentid||','||salary as "OUTPUT" 
From employees;
SELECT firstName,salary 
From employees
where salary Between 12000 and 20000;
SELECT lastName,jobid,hiredate
From employees
where hiredate between '20-Feb-1998' and '1-May-1998';
SELECT *
From employees
where departmentid in (10,20,50);
SELECT * 
From employees
where commision_pct >0 And departmentid in (10,20);



