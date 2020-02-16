﻿create Procedure [dbo].[GetEmployeeFrom NameAndSurname] @name varchar(100), @surname varchar(100)
as
declare 
@idAccess int
,@idAdress int
,@idContactDetails int
,@Employee int
select e.idEmployee, e.name, e.surname, e.department, e.position,
login, password, street, houseNumber,apartmentNumber,city, zipCode,country, phoneNumber, email,webside , e.idAccess , e.idAdress , e.idContactDetails, e.created,e.createdBy,e.modified,e.modifiedBy
from employee e 
inner join Access on e.idAccess =  Access.idAccess 
inner join Adress on e.idAdress = Adress.idAdress 
inner join contactDetails on e.idContactDetails = contactDetails.idcontactDetails
where @name = name and @surname =surname