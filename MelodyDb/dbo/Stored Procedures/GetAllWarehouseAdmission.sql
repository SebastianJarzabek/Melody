
Create Procedure [dbo].GetAllWarehouseAdmission
as
begin Transaction
SELECT w.Id  as Id
	  ,w.WarehouseAdmissionNumber as 'WarehouseAdmissionNumber'
      ,w.DateOfAdmission as 'DateOfAdmission'
      ,w.[hostEmployee] as 'HostEmployee'
	  ,s.Name as 'SupplierName'
	  ,o.OrderNumber as 'OrderNumber'
      ,d.name as 'DestinyName'
	  ,d.contract as 'Contract'
	  ,m.name as 'MaterialName'
	  ,m.type as 'MaterialType'
      ,w.[quantity] as 'Quantity'
      ,u.name as 'UnitName'
      ,n.note as 'NoteFullText'
      ,w.[created]
      ,w.[createdBy]
      ,w.[modified]
      ,w.[modifiedBy]
  FROM [dbo].WarehouseAdmission w
inner join [Order]  o on w.idOrder = o.Id
inner join Destiny  d on w.idDestiny = d.Id
inner join Supplier  s on w.IdSupplier = s.Id
inner join Material m on w.idMaterial = m.Id
inner join Unit u  on w.idUnit =  u.Id
inner join Note  n on w.idNote = n.Id
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION