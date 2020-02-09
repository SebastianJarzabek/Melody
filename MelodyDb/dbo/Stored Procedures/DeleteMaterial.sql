Create Procedure DeleteMaterial
@name varchar(100)
,@type int
as
begin Transaction
Delete Material where name=@name or type = @type
IF @@ERROR <> 0
    BEGIN
        ROLLBACK TRANSACTION
        return 11
    END
COMMIT TRANSACTION
