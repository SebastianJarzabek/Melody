
Create Procedure UpdateMaterial
@idMaterial int 
,@name varchar(100)
,@type varchar(100)
as
begin Transaction
update  Material set  name = @name, type = @type 
where idMaterial= @idMaterial or name = @name or type = @type 
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
