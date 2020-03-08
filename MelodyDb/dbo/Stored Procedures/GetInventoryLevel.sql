
CREATE Procedure [dbo].[GetInventoryLevel] 
as
begin Transaction
select il.Id as Id,
m.name as MaterialName,
m.type as MaterialType,
u.name as UnitName,
il.quantity as Quantity
from  InventoryLevel as il
inner join Material as m  on il.idMaterial = m.Id
inner join Unit as u on il.idUnit = u.Id
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION