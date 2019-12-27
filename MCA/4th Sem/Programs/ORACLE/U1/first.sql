CREATE TABLE locations(
  locationId number(2) PRIMARY KEY,
  city VARCHAR2(20)
  );
  
CREATE TABLE departments(
  departmentId number(2) PRIMARY KEY,
  departmentName VARCHAR2(20),
  managerId number(2),
  locationId number(2),
  FOREIGN KEY (locationId) REFERENCES locations(locationId)
);