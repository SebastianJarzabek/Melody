CREATE TABLE [dbo].[WarehouseAdmission] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [DateOfAdmission] DATETIME      NOT NULL,
    [HostEmployee]    VARCHAR (100) NULL,
    [IdSupplier]      INT           NOT NULL,
    [IdOrder]         INT           NOT NULL,
    [IdMaterial]      INT           NOT NULL,
    [Quantity]        INT           NOT NULL,
    [IdUnit]          INT           NOT NULL,
    [IdDestiny]       INT           NOT NULL,
    [IdNote]          INT           NULL,
    [Created]         DATETIME      NOT NULL,
    [CreatedBy]       VARCHAR (100) NOT NULL,
    [Modified]        DATETIME      NULL,
    [ModifiedBy]      VARCHAR (100) NULL,
    CONSTRAINT [PK_WarehouseAdmission] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_WarehouseAdmission_Destiny] FOREIGN KEY ([IdDestiny]) REFERENCES [dbo].[Destiny] ([Id]),
    CONSTRAINT [FK_WarehouseAdmission_Material] FOREIGN KEY ([IdMaterial]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_WarehouseAdmission_Note] FOREIGN KEY ([IdNote]) REFERENCES [dbo].[Note] ([Id]),
    CONSTRAINT [FK_WarehouseAdmission_Order] FOREIGN KEY ([IdOrder]) REFERENCES [dbo].[Order] ([Id]),
    CONSTRAINT [FK_WarehouseAdmission_Supplier] FOREIGN KEY ([IdSupplier]) REFERENCES [dbo].[Supplier] ([Id]),
    CONSTRAINT [FK_WarehouseAdmission_Unit] FOREIGN KEY ([IdUnit]) REFERENCES [dbo].[Unit] ([Id])
);




GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].WarehouseAdmission_Update
   ON  dbo.WarehouseAdmission
   AFTER UPDATE
AS 
BEGIN
	Update [dbo].WarehouseAdmission set modified=GETDATE(),
	modifiedBy =SYSTEM_USER
END
