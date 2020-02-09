Create Procedure UpdateDestiny
@idDestiny int 
,@name varchar(100)
,@contract int
as
begin Transaction
update  Destiny set  name = @name, contract = @contract 
where idDestiny= @idDestiny or name = @name or contract = @contract 
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
