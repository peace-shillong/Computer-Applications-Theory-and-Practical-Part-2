SET SERVEROUTPUT ON
DECLARE
  mulno number;
  i number;
  r number;
  c number;
  
BEGIN
  DBMS_OUTPUT.PUT_LINE('ARMSTRONG NUMBER');
  c:=0;
  mulno:=153;
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
    DBMS_OUTPUT.PUT_LINE('It is an Armstong No');
  End if;
END;