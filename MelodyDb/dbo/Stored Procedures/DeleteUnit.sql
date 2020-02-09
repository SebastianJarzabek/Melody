Create Procedure DeleteUnit
@name varchar(100)
as
begin Transaction
Delete Unit where name=@name
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
