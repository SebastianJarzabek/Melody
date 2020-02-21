
Create Procedure [dbo].[GetAllSupplier] 
as
begin Transaction
select name, street, houseNumber,apartmentNumber,city, zipCode,country, phoneNumber, email,webside
from Supplier e 
inner join Adress on e.idAdress = Adress.Id 
inner join contactDetails on e.idContactDetails = contactDetails.Id
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION