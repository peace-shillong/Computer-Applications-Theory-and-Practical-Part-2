SET SERVEROUTPUT ON
DECLARE
  mulno number;
  i number;
  r number;
  c number;
  co number;
  
BEGIN
  DBMS_OUTPUT.PUT_LINE('ARMSTRONG NUMBER');
  co:=1;
  mulno:=1;
  LOOP
  c:=0;
  mulno:=co;
  i:=mulno;
  WHILE mulno>0 LOOP
    r:=MOD(mulno,10);
    c:=c + (r**3);
    --DBMS_OUTPUT.PUT_LINE(r);
    --DBMS_OUTPUT.PUT_LINE(c);
    mulno:=mulno/10;
    mulno:=trunc(mulno);
--    DBMS_OUTPUT.PUT_LINE(mulno);
  END LOOP;
  --  DBMS_OUTPUT.PUT_LINE(c);
  if i=c then 
    DBMS_OUTPUT.PUT_LINE(c||' is an Armstong No');
  End if;
  EXIT WHEN co=1000;
  co:=co+1;
  END LOOP;
END;