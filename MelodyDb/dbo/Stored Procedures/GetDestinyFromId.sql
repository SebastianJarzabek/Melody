
Create Procedure GetDestinyFromId 
@idDestiny int 
,@name varchar(100)
,@contract int
as
begin Transaction
select Id, name, contract from Destiny where Id= @idDestiny
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
