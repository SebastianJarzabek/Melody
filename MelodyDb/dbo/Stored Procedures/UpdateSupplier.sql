
Create Procedure UpdateSupplier
@idSupplier int 
,@name varchar(100)
,@streetIn varchar(100)
,@houseNumberIn  varchar(50)
,@apartmentNumberIn varchar(50)
,@cityIn varchar(50)
,@zipCodeIn varchar(50)
,@countryIn varchar(50)
,@phoneNumberIn int
,@emailIn  varchar(100)
,@websideIn   varchar(100)
as
begin Transaction
declare 
@idAdress int
,@idContactDetails int
set @idAdress = ( select idSupplier from Supplier where name=@name)
set @idContactDetails = ( select idSupplier from Supplier where name=@name)

UPDATE Adress
SET street = @streetIn, houseNumber = @houseNumberIn, apartmentNumber = @apartmentNumberIn, city = @cityIn, zipCode = @zipCodeIn, country = @countryIn
where idAdress = @idAdress

UPDATE ContactDetails
SET phoneNumber = @phoneNumberIn, email = @emailIn, webside = @websideIn
where idContactDetails = @idContactDetails


update  Supplier set  name = @name
where idSupplier= @idSupplier or name = @name
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
