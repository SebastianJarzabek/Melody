
Create Procedure GetUnitFromId 
@idUnit int 
,@name varchar(100)
as
begin Transaction
select Id, name from Unit where Id= @idUnit
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
