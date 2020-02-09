
create Procedure AddWarehouseAdmission
          @DateOfAdmission dateTime
		  , @idSupplier int
           ,@idOrder int
           ,@idMaterial int
           ,@quantity int
           ,@idUnit int
           ,@idDestiny int
           ,@idNote int

as
begin Transaction
declare  
@created datetime = GETDATE()
,@createdBy varchar(100)  = SYSTEM_USER

INSERT INTO [dbo].[WarehouseAdmission]
           ([DateOfAdmission]
           ,[idSupplier]
           ,[idOrder]
           ,[idMaterial]
           ,[quantity]
           ,[idUnit]
           ,[idDestiny]
           ,[idNote]
           ,[created]
           ,[createdBy])
        VALUES          ( @DateOfAdmission
           ,@idSupplier
           ,@idOrder
           ,@idMaterial
           ,@quantity
           ,@idUnit
           ,@idDestiny
           ,@idNote
           ,@created
           ,@createdBy)
		    IF @@ERROR <> 0																																																 
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
