CREATE Procedure [dbo].[AddEmployee] 
@nameIn varchar(100)
,@surnameIn varchar(100)
,@departamentIn varchar(100)
,@positionIn varchar(100)
,@loginIn varchar(50)
,@passwordIn  varchar(50)
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
@idAccess int
,@idAdress int
,@idContactDetails int
,@created datetime = GETDATE()
,@createdBy varchar(100)  = SYSTEM_USER
Insert into Access (login, password)  Values (@loginIn, @passwordIn)
set @idAccess = SCOPE_IDENTITY()
Insert into Adress(street, houseNumber,apartmentNumber,city,zipCode,country)  Values (@streetIn, @houseNumberIn, @apartmentNumberIn, @cityIn, @zipCodeIn, @countryIn)
set @idAdress = SCOPE_IDENTITY()
Insert into ContactDetails(phoneNumber,email,webside)  Values (@phoneNumberIn, @emailIn, @websideIn)
set @idContactDetails = SCOPE_IDENTITY()
Insert into Employee(name, surname, department, position,idAccess,idAdress,idContactDetails, created, createdBy)  Values (@nameIn,@surnameIn,@departamentIn,@positionIn,@idAccess,@idAdress,@idContactDetails,@created,@createdBy )
IF @@ERROR <> 0																																																 
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
