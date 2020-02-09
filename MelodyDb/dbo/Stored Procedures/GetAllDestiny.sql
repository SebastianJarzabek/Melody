create Procedure [dbo].[GetAllDestiny]
as
begin Transaction
select idDestiny, name, contract from Destiny
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION