CREATE PROCEDURE [dbo].[LastOrderNumber]
AS
BEGIN
	Select MAX(OrderNumber) From [Order]
END