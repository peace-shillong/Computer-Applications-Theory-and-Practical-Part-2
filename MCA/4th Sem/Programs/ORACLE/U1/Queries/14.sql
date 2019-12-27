select INITCAP(lastname),Length(lastname) 
from employees
where firstname like 'j%' 
order by lastname;