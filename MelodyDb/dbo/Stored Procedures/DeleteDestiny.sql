CREATE Procedure [dbo].[DeleteDestiny]
@name varchar(100) = null
,@contract int =null
as
begin Transaction
Delete Destiny where name=@name or contract = @contract
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
