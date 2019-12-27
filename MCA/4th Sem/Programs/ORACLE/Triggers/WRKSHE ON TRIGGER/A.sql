create table log_contacts
( log_id number(5) primary key,  
  log_dt date,
  operation_id varchar2(50) not null,
  username varchar2(50) not null,
  record_id number(5));
  