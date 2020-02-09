
CREATE procedure [dbo].[UsersLogin] 
                              @loginInParm varchar(50),
                              @passwordInParm varchar(50)
                          
as
IF (EXISTS (SELECT * FROM Access where ([login]=isnull(@loginInParm,null) and [password]=isnull(@passwordInParm,null))))
    SELECT 1
ELSE
    SELECT 0