
Create Procedure UpdateUnit
@idUnit int 
,@name varchar(100)
as
begin Transaction
update  Unit set  name = @name
where Id= @idUnit or name = @name
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
