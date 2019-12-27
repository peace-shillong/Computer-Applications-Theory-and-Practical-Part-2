--A package body containing a stored procedure and function for finding the smallest of three numbers
create or replace package body firstpackage is
  procedure smallest_3nos(a number,b number,c number) is
  begin 
    if a<b and a<c then
      DBMS_OUTPUT.PUT_LINE(a||' is smallest');
    elsif b<a and b<c then
      DBMS_OUTPUT.PUT_LINE(b||' is smallest');
    elsif c<b and c<a then
      DBMS_OUTPUT.PUT_LINE(c||' is smallest');
    else
      DBMS_OUTPUT.PUT_LINE('They are all equal');
    end if;
  end;
  
  function smallest_3nos_func(a number,b number,c number) return number is
  begin
    if a<b and a<c then
      return a;
    --DBMS_OUTPUT.PUT_LINE(a||' greatest');
    elsif b<a and b<c then
      return b;
--    DBMS_OUTPUT.PUT_LINE(b||' greatest');
    elsif c<b and c<a then
      return c;
  --  DBMS_OUTPUT.PUT_LINE(c||' greatest');
    else
      return -1;
    end if;
  end;
end;