-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE OnInit
	-- Add the parameters for the stored procedure here
	@Login varchar(50),
	@Password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	Declare
	@Result int
	Select @Result=1 From Access WHERE EXISTS  (Select * From Access Where Login=@Login and Password=@Password)
   if (@Result<>1)
   Insert into Access (Login, Password) Values(@Login,@Password)

END