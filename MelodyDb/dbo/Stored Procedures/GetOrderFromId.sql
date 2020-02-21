CREATE Procedure [dbo].[GetOrderFromId] 
@idOrder int
as
begin Transaction
declare 
@idAccess int
,@idAdress int
,@idContactDetails int
,@Order int
select o.Id,
 dateOfOrder
,orderingEmployee
,s.Id as 'idSupplier'
,s.name as 'SupplierName'
,d.Id as 'idDestiny'
,d.name as 'DestinyName'
,d.contract as 'DestinyContract'
,m.Id as 'idMaterial'
,m.name as 'MaterialName'
,m.type as 'MaterialType'
,quantity
,u.Id as 'idUnit'
,u.name as 'UnitName'
,n.Id as 'idNote '
,n.note as 'NoteName'
,receivingEmployee
from [Order] o
inner join Supplier s  on o.idSupplier =  s.Id
inner join Destiny  d on o.idDestiny = d.Id
inner join Material m on o.idMaterial = m.Id
inner join Unit u  on o.idUnit =  u.Id
inner join Note  n on o.idNote = n.Id

where o.Id = @idOrder

IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
