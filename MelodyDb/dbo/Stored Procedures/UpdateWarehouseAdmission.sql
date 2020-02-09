create Procedure [dbo].[UpdateWarehouseAdmission]
@idWarehouseAdmission int
          ,@DateOfAdmission dateTime
		  , @idSupplier int
           ,@idOrder int
           ,@idMaterial int
           ,@quantity int
           ,@idUnit int
           ,@idDestiny int
           ,@idNote int

as
begin Transaction
UPDATE [dbo].[WarehouseAdmission]
   SET [DateOfAdmission] = @DateOfAdmission
      ,[idSupplier] = @idSupplier
      ,[idOrder] = @idOrder
      ,[idMaterial] = @idMaterial
      ,[quantity] = @quantity
      ,[idUnit] = @idUnit
      ,[idDestiny] = @idDestiny
      ,[idNote] = @idNote
 WHERE @idWarehouseAdmission =idWarehouseAdmission
 		    IF @@ERROR <> 0																																																 
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION

