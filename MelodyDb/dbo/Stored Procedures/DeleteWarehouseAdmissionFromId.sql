

CREATE Procedure [dbo].[DeleteWarehouseAdmissionFromId] @WarehouseAdmissionNumber int
as
begin Transaction
DELETE FROM [dbo].[WarehouseAdmission]
      WHERE 
    WarehouseAdmissionNumber = @WarehouseAdmissionNumber
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
