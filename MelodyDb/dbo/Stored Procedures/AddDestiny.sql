
CREATE Procedure [dbo].[AddDestiny]
@Name varchar(100)
,@Contract int
as
begin Transaction
Insert into Destiny (name, contract) values (@name,@contract)
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
