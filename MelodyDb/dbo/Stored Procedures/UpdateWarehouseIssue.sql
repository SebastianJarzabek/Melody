create Procedure UpdateWarehouseIssue 
@idWarehouseIssue int
       ,@dateOfReceipt datetime
      ,@receivingEmployee varchar(100)
      ,@hostEmployee varchar(100)
      ,@idOrder int
      ,@idDestiny int
      ,@idMaterial int
      ,@quantity int
      ,@idUnit int
      ,@idNote int
as
begin Transaction
UPDATE [dbo].[WarehouseIssue]
   SET [dateOfReceipt] =  @dateOfReceipt
      ,[receivingEmployee] = @receivingEmployee
      ,[hostEmployee] = @hostEmployee
      ,[idOrder] = @hostEmployee
      ,[idDestiny] =@idOrder
      ,[idMaterial] =@idMaterial
      ,[quantity] = @quantity
      ,[idUnit] = @idUnit
      ,[idNote] = @idNote
 WHERE @idWarehouseIssue=idWarehouseIssue
 IF @@ERROR <> 0																																																 
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
