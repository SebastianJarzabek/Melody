
Create Procedure AddDestiny
@name varchar(100)
,@contract int
as
begin Transaction
Insert into Destiny (name, contract) values (@name,@contract)
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
