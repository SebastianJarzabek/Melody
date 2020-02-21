CREATE Procedure UpdateEmployee 
@Id int
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
set @Employee = ( select Id from Employee where Id = @Id or name=@nameIn and surname=@surnameIn)
set @idAccess = ( select Id from Employee where name=@nameIn and surname=@surnameIn)
set @idAdress = ( select Id from Employee where name=@nameIn and surname=@surnameIn)
set @idContactDetails = ( select Id from Employee where name=@nameIn and surname=@surnameIn)


UPDATE Access
SET login = @loginIn, password = @passwordIn
WHERE Id = @idAccess

UPDATE Adress
SET street = @streetIn, houseNumber = @houseNumberIn, apartmentNumber = @apartmentNumberIn, city = @cityIn, zipCode = @zipCodeIn, country = @countryIn
where Id = @idAdress

UPDATE ContactDetails
SET phoneNumber = @phoneNumberIn, email = @emailIn, webside = @websideIn
where Id = @idContactDetails

UPDATE Employee
SET name =@nameIn, surname = @surnameIn, department = @departamentIn, position = @positionIn
where Id=@Employee

IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
