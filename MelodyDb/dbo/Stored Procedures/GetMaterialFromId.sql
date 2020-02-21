
Create Procedure GetMaterialFromId 
@idMaterial int 
,@name varchar(100)
,@type varchar(100)
as
begin Transaction
select Id, name, type from Material where Id= @idMaterial
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
