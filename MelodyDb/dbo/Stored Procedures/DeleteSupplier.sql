CREATE Procedure DeleteSupplier
@name varchar(100)
as
begin Transaction
declare
@idAdress int
,@idContactDetails int 
select @idAdress = idAdress, @idContactDetails = idContactDetails from Supplier
Delete Supplier where name=@name
delete Adress where Id = @idAdress
delete ContactDetails where Id = @idContactDetails
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
