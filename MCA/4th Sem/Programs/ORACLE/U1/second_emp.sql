CREATE TABLE employees(
  employeeId number(2) PRIMARY KEY,
  firstName VARCHAR2(20) NOT NULL,
  lastName VARCHAR2(20) NOT NULL,
  email VARCHAR2(20) UNIQUE,
  phoneNo NUMBER(6) NOT NULL,
  hireDate Date NOT NULL,
  commision_pct NUMBER(4),
  jobId VARCHAR2(20) NOT NULL,
  managerId NUMBER(2) default NULL,
  departmentId NUMBER(2),
  salary NUMBER(6) CHECK (salary>0),
  FOREIGN KEY(departmentId) REFERENCES departments(departmentId)
);
--comment
/*
  comment
*/