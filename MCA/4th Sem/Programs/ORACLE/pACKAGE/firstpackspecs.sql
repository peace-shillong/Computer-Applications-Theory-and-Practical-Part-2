--A package specification containing a stored procedure and function for finding the smallest of three numbers
create or replace package firstpackage is 
  procedure smallest_3nos(a number,b number,c number);
  function smallest_3nos_func(a number,b number,c number) return number;
end;