create Procedure GetAllWarehouseIssueFromId @idWarehouseIssue int
as
begin Transaction
SELECT w.[idWarehouseIssue]
      ,w.[dateOfReceipt]
      ,w.[receivingEmployee]
      ,w.[hostEmployee]
      ,o.[idOrder]
      ,d.name as 'DestinyName'
	  ,d.contract as 'DestinyContract'
      ,m.idMaterial
	  ,m.name as 'MaterialName'
	  ,m.type as 'MaterialType'
      ,w.[quantity]
      ,u.idUnit
      ,u.name as 'UnitName'
      ,n.idNote 
      ,n.note as 'NoteName'
      ,w.[created]
      ,w.[createdBy]
      ,w.[modified]
      ,w.[modifiedBy]
  FROM [dbo].[WarehouseIssue] w
inner join [Order]  o on w.idOrder = o.idOrder
inner join Destiny  d on w.idDestiny = d.idDestiny
inner join Material m on w.idMaterial = m.idMaterial
inner join Unit u  on w.idUnit =  u.idUnit
inner join Note  n on w.idNote = n.idNote
where @idWarehouseIssue=w.idWarehouseIssue
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
