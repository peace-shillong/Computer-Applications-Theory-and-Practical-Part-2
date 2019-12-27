--procedure to print >3 no
create or replace procedure gr_3nos(a number,b number,c number) is
begin
  
  if a>b and a>c then
    DBMS_OUTPUT.PUT_LINE(a||' greatest');
  elsif b>a and b>c then
    DBMS_OUTPUT.PUT_LINE(b||' greatest');
  elsif c>b and c>a then
    DBMS_OUTPUT.PUT_LINE(c||' greatest');
  else
    DBMS_OUTPUT.PUT_LINE('They are all equal');
  end if;

end;
