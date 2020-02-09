Create Procedure DeleteSupplier
@name varchar(100)
as
begin Transaction
declare
@idAdress int
,@idContactDetails int 
select @idAdress = idAdress, @idContactDetails = idContactDetails from Supplier
Delete Supplier where name=@name
delete Adress where idAdress = @idAdress
delete ContactDetails where idContactDetails = @idContactDetails
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
