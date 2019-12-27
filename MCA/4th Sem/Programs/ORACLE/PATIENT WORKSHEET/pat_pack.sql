create or replace package pat_pack is 
  procedure list_patient;
  procedure list_by_city(city in varchar2);
  function getcost(t_name in varchar2) return number;
end pat_pack;