CREATE Procedure [dbo].[AddOrder] 
@dateOfOrderIn varchar(100)
,@orderingEmployeeIn varchar(100)
,@idSupplierIn varchar(100)
,@dateOfAdmissionIn varchar(100)
,@hostEmployeeIn varchar(50)
,@idDestinyIn  varchar(50)
,@idMaterialIn varchar(100)
,@quantityIn  varchar(50)
,@idUnitIn varchar(50)
,@idNoteIn varchar(50)
,@receivingEmployeeIn varchar(50)
,@plannedDateOfReceiptIn varchar(50)

as
begin Transaction
declare 
@idSupplier int
 ,@idDestiny int
 ,@idMaterial int
 ,@idUnit int
 ,@idNote int
 ,@created datetime = GETDATE()
,@createdBy varchar(100)  = SYSTEM_USER
Insert into [dbo].[Order](
dateOfOrder
, orderingEmployee
, idSupplier
,idDestiny
,idMaterial
,quantity
,idUnit
,idNote
,receivingEmployee
,plannedDateOfReceipt 
,created
,createdBy)  
Values (@dateOfOrderIn 
,@orderingEmployeeIn 
,@idSupplierIn 
,@dateOfAdmissionIn 
,@hostEmployeeIn 
,@idDestinyIn  
,@idMaterialIn
,@quantityIn 
,@idUnitIn 
,@idNoteIn 
,@receivingEmployeeIn 
,@plannedDateOfReceiptIn 
,@created
,@createdBy
)
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
