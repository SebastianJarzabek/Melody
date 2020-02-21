Create Procedure GetDestiny
@name varchar(100)
,@contract int
as
begin Transaction
select Id, name, contract from Destiny
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
