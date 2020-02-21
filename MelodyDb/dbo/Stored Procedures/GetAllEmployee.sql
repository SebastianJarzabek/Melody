create Procedure [dbo].[GetAllEmployee] 
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

