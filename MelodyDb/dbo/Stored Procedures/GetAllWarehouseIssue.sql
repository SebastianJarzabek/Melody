create Procedure GetAllWarehouseIssue
as
begin Transaction
SELECT w.Id
      ,w.[dateOfReceipt]
      ,w.[receivingEmployee]
      ,w.[hostEmployee]
      ,o.Id
      ,d.name as 'DestinyName'
	  ,d.contract as 'DestinyContract'
      ,m.Id
	  ,m.name as 'MaterialName'
	  ,m.type as 'MaterialType'
      ,w.[quantity]
      ,u.Id
      ,u.name as 'UnitName'
      ,n.Id 
      ,n.note as 'NoteName'
      ,w.[created]
      ,w.[createdBy]
      ,w.[modified]
      ,w.[modifiedBy]
  FROM [dbo].[WarehouseIssue] w
inner join [Order]  o on w.idOrder = o.Id
inner join Destiny  d on w.idDestiny = d.Id
inner join Material m on w.idMaterial = m.Id
inner join Unit u  on w.idUnit =  u.Id
inner join Note  n on w.idNote = n.Id
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
