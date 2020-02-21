create Procedure DeleteWarehouseIssueFromId @idWarehouseIssue int
as
begin Transaction
Delete [WarehouseIssue] where 
    Id=@idWarehouseIssue
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
