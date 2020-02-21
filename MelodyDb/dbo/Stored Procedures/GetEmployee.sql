CREATE Procedure GetEmployee 
@Id int
,@nameIn varchar(100)
,@surnameIn varchar(100)
as
declare 
@idAccess int
,@idAdress int
,@idContactDetails int
,@Employee int
select e.Id, e.name, e.surname, e.department, e.position,
login, password, street, houseNumber,apartmentNumber,city, zipCode,country, phoneNumber, email,webside , e.idAccess , e.idAdress , e.idContactDetails, e.created,e.createdBy,e.modified,e.modifiedBy
from employee e 
inner join Access on e.idAccess =  Access.Id 
inner join Adress on e.idAdress = Adress.Id 
inner join contactDetails on e.idContactDetails = contactDetails.Id
where e.Id = @Id or (name=@nameIn and e.surname=@surnameIn)
