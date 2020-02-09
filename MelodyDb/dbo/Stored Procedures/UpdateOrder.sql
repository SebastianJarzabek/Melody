create Procedure UpdateOrder 
@idOrder int
,@dateOfOrderIn varchar(100)
,@orderingEmployeeIn varchar(100)
,@idSupplierIn varchar(100)
,@idDestinyIn  varchar(50)
,@idMaterialIn varchar(100)
,@quantityIn  varchar(50)
,@idUnitIn varchar(50)
,@idNoteIn varchar(50)
,@receivingEmployeeIn varchar(50)
,@plannedDateOfReceiptIn varchar(50)
as
begin Transaction

UPDATE [Order]
SET 
dateOfOrder 	  = @dateOfOrderIn
,orderingEmployee =	@orderingEmployeeIn 
,idSupplier		  =	@idSupplierIn
,idDestiny		  =	@idDestinyIn
,idMaterial		  =	@idMaterialIn
,quantity		  =	@quantityIn
,idUnit			  =	@idUnitIn
,idNote			  =	@idNoteIn
,receivingEmployee=	@receivingEmployeeIn
,plannedDateOfReceipt	  =	@plannedDateOfReceiptIn
WHERE idOrder = @idOrder


IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
