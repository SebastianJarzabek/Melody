CREATE PROCEDURE [dbo].[OnInit]
	-- Add the parameters for the stored procedure here
	@Login varchar(50),
	@Password varchar(50)
AS
BEGIN
   IF NOT EXISTS (Select * From Access Where Login=@Login and Password=@Password)
   BEGIN
       Insert into Access (Login, Password) Values(@Login,@Password)
   END
END