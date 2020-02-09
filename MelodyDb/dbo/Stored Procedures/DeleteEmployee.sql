CREATE Procedure DeleteEmployee 
@nameIn varchar(100)
,@surnameIn varchar(100)
as
begin Transaction
declare 
@Employee int
select  @Employee = idEmployee from employee where name=@nameIn and surname=@surnameIn
delete Employee where idEmployee=@Employee
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
