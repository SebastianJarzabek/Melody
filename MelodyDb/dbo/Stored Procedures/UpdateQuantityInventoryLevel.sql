﻿Create Procedure UpdateQuantityInventoryLevel
@idInventoryLevel int 
,@quantity int
as
begin Transaction
update  InventoryLevel set  quantity = @quantity
where idInventoryLevel= @idInventoryLevel   BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
