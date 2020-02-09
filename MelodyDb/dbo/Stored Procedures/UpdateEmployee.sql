CREATE Procedure UpdateEmployee 
@idEmployee int
,@nameIn varchar(100)
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
,@phoneNumberIn int
,@emailIn  varchar(100)
,@websideIn   varchar(100)
as
begin Transaction
declare 
@idAccess int
,@idAdress int
,@idContactDetails int
,@Employee int
set @Employee = ( select idEmployee from Employee where idEmployee = @idEmployee or name=@nameIn and surname=@surnameIn)
set @idAccess = ( select idEmployee from Employee where name=@nameIn and surname=@surnameIn)
set @idAdress = ( select idEmployee from Employee where name=@nameIn and surname=@surnameIn)
set @idContactDetails = ( select idEmployee from Employee where name=@nameIn and surname=@surnameIn)


UPDATE Access
SET login = @loginIn, password = @passwordIn
WHERE idAccess = @idAccess

UPDATE Adress
SET street = @streetIn, houseNumber = @houseNumberIn, apartmentNumber = @apartmentNumberIn, city = @cityIn, zipCode = @zipCodeIn, country = @countryIn
where idAdress = @idAdress

UPDATE ContactDetails
SET phoneNumber = @phoneNumberIn, email = @emailIn, webside = @websideIn
where idContactDetails = @idContactDetails

UPDATE Employee
SET name =@nameIn, surname = @surnameIn, department = @departamentIn, position = @positionIn
where idEmployee=@Employee

IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
