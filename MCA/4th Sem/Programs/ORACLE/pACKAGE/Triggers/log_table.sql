create table log_table
( log_id number(5) primary key,
  username varchar2(30) not null,
  log_dt date,
  operation varchar2(100),
  record_key number(5));
  