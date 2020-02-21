CREATE TABLE [dbo].[InventoryLevel] (
    [IdInventoryLevel] INT IDENTITY (1, 1) NOT NULL,
    [IdMaterial]       INT NOT NULL,
    [Quantity]         INT NOT NULL,
    [IdUnit]           INT NOT NULL,
    CONSTRAINT [PK_InventoryLevel] PRIMARY KEY CLUSTERED ([IdInventoryLevel] ASC),
    CONSTRAINT [FK_InventoryLevel_Material] FOREIGN KEY ([IdMaterial]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_InventoryLevel_Unit] FOREIGN KEY ([IdUnit]) REFERENCES [dbo].[Unit] ([Id])
);




GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER AddingToInventory
   ON  [dbo].InventoryLevel
   AFTER INSERT
AS 
BEGIN
declare 
@quantityToAdd int
,@idMaterial int 
,@quantity int
	set @quantityToAdd = (select quantity from [order] where  (SELECT IDENT_CURRENT('Table')) = idOrder)
	set @idMaterial = (select idMaterial from [order] where  (SELECT IDENT_CURRENT('Table')) = idOrder)
	set @quantity = (select quantity from InventoryLevel where  idMaterial = @idMaterial)
	SET NOCOUNT ON;
	Update InventoryLevel set  quantity= (@quantityToAdd+ @quantity) 
	where idMaterial = @idMaterial
    -- Insert statements for trigger here
	
END

GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER SubtractionFromInventory
   ON  [dbo].InventoryLevel
   AFTER INSERT
AS 
BEGIN
declare 
@quantityToSubtract int
,@idMaterial int 
,@quantity int
	set @quantityToSubtract = (select quantity from WarehouseIssue where  (SELECT IDENT_CURRENT('Table')) = idOrder)
	set @idMaterial = (select Id from WarehouseIssue where  (SELECT IDENT_CURRENT('Table')) = idOrder)
	set @quantity = (select quantity from InventoryLevel where  idMaterial = @idMaterial)
	SET NOCOUNT ON;
	Update InventoryLevel set  quantity= (@quantity - @quantityToSubtract) 
	where idMaterial = @idMaterial
    -- Insert statements for trigger here
	
END
