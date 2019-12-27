select employeeid,lastname,salary,salary+((salary*15)/100) as "new salary"
from employees;
