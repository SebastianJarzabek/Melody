CREATE Procedure [dbo].[DeleteOrder] 
@OrderNumber int
as
begin Transaction

delete [Order] where OrderNumber=@OrderNumber
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
