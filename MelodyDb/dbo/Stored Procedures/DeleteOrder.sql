Create Procedure DeleteOrder 
@Order int
as
begin Transaction

delete [Order] where Id=@Order
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
