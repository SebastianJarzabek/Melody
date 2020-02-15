

CREATE Procedure GetAllOrder

as
begin Transaction
select idOrder,
 dateOfOrder
,orderingEmployee
,s.idSupplier
,s.name as 'SupplierName'
--,dateOfAdmission
--,hostEmployee
,d.idDestiny
,d.name as 'DestinyName'
,d.contract as 'DestinyContract'
,m.idMaterial
,m.name as 'MaterialName'
,m.type as 'MaterialType'
,quantity
,u.idUnit
,u.name as 'UnitName'
,n.idNote 
,n.note as 'NoteName'
,receivingEmployee
--,dateOfReceipt
from [Order] o
inner join Supplier s  on o.idSupplier =  s.idSupplier
inner join Destiny  d on o.idDestiny = d.idDestiny
inner join Material m on o.idMaterial = m.idMaterial
inner join Unit u  on o.idUnit =  u.idUnit
inner join Note  n on o.idNote = n.idNote
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
