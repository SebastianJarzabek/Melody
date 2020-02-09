
Create Procedure AddMaterial
@name varchar(100)
,@type varchar(100)
as
begin Transaction
Insert into Material (name, type) values (@name,@type)
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
