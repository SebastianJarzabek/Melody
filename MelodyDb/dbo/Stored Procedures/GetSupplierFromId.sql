
Create Procedure GetSupplierFromId 
@idSupplier int 
,@name varchar(100)
as
declare 
@idAdress int
,@idContactDetails int
begin Transaction
select @idAdress= idAdress, @idContactDetails = idContactDetails from Supplier 
select name, street, houseNumber,apartmentNumber,city, zipCode,country, phoneNumber, email,webside
from Supplier e 
inner join Adress on e.idAdress = Adress.Id 
inner join contactDetails on e.idContactDetails = contactDetails.Id
where e.Id = @idSupplier or name=@name 
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
