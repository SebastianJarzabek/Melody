
Create Procedure AddUnit
@name varchar(100)
as
begin Transaction
Insert into Unit (name) values (@name)
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
