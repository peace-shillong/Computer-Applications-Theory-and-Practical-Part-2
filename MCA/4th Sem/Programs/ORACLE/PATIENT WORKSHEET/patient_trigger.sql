create or replace trigger patient_trigger
after insert or update or delete on treatment
for each row
begin
    IF INSERTING THEN
			INSERT INTO trig1_log(log_id, log_dml, log_key_id, log_usr, log_date)
			VALUES(seq.nextval, ‘INSERT’, :new.patient_id, user, SYSDATE);
		ELSIF DELETING THEN
	 		INSERT INTO trig1_log(log_id, log_dml, log_key_id, log_usr, log_date)
			VALUES(seq.nextval, ‘DELETE’, :old.patient_id, user, SYSDATE)
		ELSE
			INSERT INTO trig1_log(log_id, log_dml, log_key_id, log_usr, log_date)
			VALUES(seq.nextval, ‘UPDATE’, :old.patient_id, user, SYSDATE);
     	END IF;

end;