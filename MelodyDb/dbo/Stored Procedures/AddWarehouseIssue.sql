CREATE Procedure AddWarehouseIssue 
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
declare  
@created datetime = GETDATE()
,@createdBy varchar(100)  = SYSTEM_USER

INSERT INTO [dbo].[WarehouseIssue]
           ([dateOfReceipt]
           ,[receivingEmployee]
           ,[hostEmployee]
           ,[idOrder]
           ,[idDestiny]
           ,[idMaterial]
           ,[quantity]
           ,[idUnit]
           ,[idNote]
           ,[created]
           ,[createdBy])
     VALUES
	 (      @dateOfReceipt 
      ,@receivingEmployee 
      ,@hostEmployee 
      ,@idOrder 
      ,@idDestiny 
      ,@idMaterial 
      ,@quantity 
      ,@idUnit 
      ,@idNote 
	  ,@created 
	  ,@createdBy)
 IF @@ERROR <> 0																																																 
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
