CREATE Procedure [dbo].[AddSupplier]
@name varchar(100)
,@streetIn varchar(100)
,@houseNumberIn  varchar(50)
,@apartmentNumberIn varchar(50)
,@cityIn varchar(50)
,@zipCodeIn varchar(50)
,@countryIn varchar(50)
,@phoneNumberIn varchar(50)
,@emailIn  varchar(100)
,@websideIn   varchar(100)
as
begin Transaction
declare 
@idAdress int
,@idContactDetails int
Insert into Adress(street, houseNumber,apartmentNumber,city,zipCode,country)  Values (@streetIn, @houseNumberIn, @apartmentNumberIn, @cityIn, @zipCodeIn, @countryIn)
set @idAdress = SCOPE_IDENTITY()
Insert into ContactDetails(phoneNumber,email,webside)  Values (@phoneNumberIn, @emailIn, @websideIn)
set @idContactDetails = SCOPE_IDENTITY()
Insert into Supplier (name,idAdress,idContactDetails) values (@name,@idAdress,@idContactDetails)
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
