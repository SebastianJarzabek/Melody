

CREATE Procedure [dbo].[GetAllOrder]

as
begin Transaction
select o.Id,
 dateOfOrder
,orderingEmployee
,s.Id
,s.name as 'SupplierName'
,d.Id as 'DestinyId'
,d.name as 'DestinyName'
,d.contract as 'DestinyContract'
,m.Id  as 'MaterialId'
,m.name as 'MaterialName'
,m.type as 'MaterialType'
,quantity
,u.Id as 'UnitId'
,u.name as 'UnitName'
,n.Id as 'NoteId'
,n.note as 'NoteName'
,receivingEmployee
from [Order] o
inner join Supplier s  on o.idSupplier =  s.Id
inner join Destiny  d on o.idDestiny = d.Id
inner join Material m on o.idMaterial = m.Id
inner join Unit u  on o.idUnit =  u.Id
inner join Note  n on o.idNote = n.Id
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
