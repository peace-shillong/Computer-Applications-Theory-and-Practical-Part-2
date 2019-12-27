SET SERVEROUTPUT ON
DECLARE
  looptype number;
  mulno number;
  i number;
BEGIN
  DBMS_OUTPUT.PUT_LINE('MULTIPLICATION TABLE');
  i:=0;
  mulno:=5;
  LOOP 
    DBMS_OUTPUT.PUT_LINE(mulno || ' x ' || i ||' = ' || mulno*i);
  i:=i+1;
  EXIT WHEN i>12;
  END LOOP;

    DBMS_OUTPUT.PUT_LINE('Multipliation Talbe');
  FOR i in 0..12 LOOP
    DBMS_OUTPUT.PUT_LINE(mulno || ' x ' || i ||' = ' || mulno*i);
  END LOOP;
    DBMS_OUTPUT.PUT_LINE('MULTIPLICATION TABLE');
 i:=0;
  WHILE i<13 LOOP
    DBMS_OUTPUT.PUT_LINE(mulno || ' x ' || i ||' = ' || mulno*i);
    i:=i+1;
  END LOOP;
END;