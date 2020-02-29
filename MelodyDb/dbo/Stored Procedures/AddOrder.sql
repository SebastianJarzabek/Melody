CREATE Procedure [dbo].[AddOrder] 
    @OrderNumber varchar(50)
    ,@DateOfOrder varchar(50)
    ,@OrderingEmployee varchar(50) 
    ,@SupplierName varchar(50)
    ,@DestinyName varchar(50)
    ,@Contract varchar(50)
    ,@MaterialName varchar(50)
    ,@MaterialType varchar(50)
    ,@Quantity varchar(50)
    ,@UnitName  varchar(50)
    ,@NoteFullText varchar(max)
    ,@ReceivingEmployee varchar(50)
    ,@PlannedDateOfReceipt varchar(50)

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

if exists (select Id from Supplier where name = @SupplierName)
select @idSupplier = Id from Supplier where name = @SupplierName
else 
Insert into Supplier (name) values (@SupplierName)
select @idSupplier=id from Supplier where name = @SupplierName

if exists (select id from Destiny where name = @DestinyName)
select @idDestiny=id from Destiny where name = @DestinyName
else 
Insert into Destiny (name) values (@DestinyName)
select @idDestiny=id from Destiny where name = @DestinyName

if exists (select id from Material where name = @MaterialName)
select @idMaterial=id from Material where name = @MaterialName
else 
Insert into Material (name) values (@MaterialName)
select @idMaterial=id from Material where name = @MaterialName

if exists (select id from Unit where name = @UnitName)
select @idUnit=id from Unit where name = @UnitName
else 
Insert into Unit (name) values (@UnitName)
select @idUnit=id from Unit where name = @UnitName

if exists (select id from Note where Note = @NoteFullText)
select @idNote=id from Note where Note = @NoteFullText
else 
Insert into Note (Note) values (@idNote)
select @idNote=id from Note where Note = @idNote

Insert into [dbo].[Order](
orderNumber
,dateOfOrder
, orderingEmployee
, idSupplier
,idDestiny
,idMaterial
,quantity
,idUnit
,idNote
,receivingEmployee
,PlannedDateOfReceipt
,created
,createdBy)  
Values (
@orderNumber
,@dateOfOrder 
,@orderingEmployee
,@idSupplier
,@idDestiny 
,@idMaterial
,@quantity
,@idUnit
,@idNote
,@receivingEmployee
,@PlannedDateOfReceipt
,@created
,@createdBy
)
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
