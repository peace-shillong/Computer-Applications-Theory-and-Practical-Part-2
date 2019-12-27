--function to return >3 no
create or replace function gr_3nosfn(a number,b number,c number) return number is
begin
  
  if a>b and a>c then
    return a;
    --DBMS_OUTPUT.PUT_LINE(a||' greatest');
  elsif b>a and b>c then
    return b;
--    DBMS_OUTPUT.PUT_LINE(b||' greatest');
  elsif c>b and c>a then
    return c;
  --  DBMS_OUTPUT.PUT_LINE(c||' greatest');
  else
  return -1;
--    DBMS_OUTPUT.PUT_LINE('They are all equal');
  end if;

end;
