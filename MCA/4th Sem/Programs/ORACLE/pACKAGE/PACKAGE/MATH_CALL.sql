set serveroutput on;
  begin
    dbms_output.put_line('the number is:'||MATH_PACK.EVENODD(4));
    END;