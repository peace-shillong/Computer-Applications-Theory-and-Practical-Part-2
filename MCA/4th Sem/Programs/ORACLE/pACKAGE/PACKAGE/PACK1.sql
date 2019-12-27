--Create a package specification as well as
-- body which involves three procedures 
--and one function. Each procedure should
-- be used for performing a DML operation
--(INSERT, UPDATE, and DELETE) on the Locations
-- table. The function should return the total
-- number of records available in the Locations table.

CREATE OR REPLACE PACKAGE PACK1 IS
  PROCEDURE TO_INSERT(LOCID NUMBER,CITY VARCHAR2);
  PROCEDURE TO_UPDATE(ULOCID NUMBER,UCITY VARCHAR2);
  PROCEDURE TO_DELETE(DLOCID NUMBER,DCITY VARCHAR2);
  FUNCTION F1 RETURN NUMBER;
END PACK1;
  