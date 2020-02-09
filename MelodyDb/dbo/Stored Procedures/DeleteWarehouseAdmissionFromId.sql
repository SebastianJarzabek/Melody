﻿

create Procedure DeleteWarehouseAdmissionFromId @idWarehouseAdmission int
as
begin Transaction
DELETE FROM [dbo].[WarehouseAdmission]
      WHERE 
    @idWarehouseAdmission=idWarehouseAdmission
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
