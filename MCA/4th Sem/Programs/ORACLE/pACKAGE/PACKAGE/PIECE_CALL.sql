SET SERVEROUTPUT ON;
BEGIN
  DBMS_OUTPUT.PUT_LINE('----------------------------------------------');
  DBMS_OUTPUT.PUT_LINE('PIECE DETAILS: ');
  PIECE_PACK.TO_DISPLAY;
  DBMS_OUTPUT.PUT_LINE('----------------------------------------------');
  DBMS_OUTPUT.PUT_LINE('THE MOST EXPENSIVE PIECE: ' ||PIECE_PACK.EXP_PIECE);
  DBMS_OUTPUT.PUT_LINE('----------------------------------------------');
  DBMS_OUTPUT.PUT_LINE('BUYER NAME FOR PIECE ID: ' ||PIECE_PACK.NAME(80));

END;