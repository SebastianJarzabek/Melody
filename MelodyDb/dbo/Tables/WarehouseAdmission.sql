CREATE TABLE [dbo].[WarehouseAdmission] (
    [idWarehouseAdmission] INT           IDENTITY (1, 1) NOT NULL,
    [DateOfAdmission]      DATETIME      NOT NULL,
    [hostEmployee]         VARCHAR (100) NULL,
    [idSupplier]           INT           NOT NULL,
    [idOrder]              INT           NOT NULL,
    [idMaterial]           INT           NOT NULL,
    [quantity]             INT           NOT NULL,
    [idUnit]               INT           NOT NULL,
    [idDestiny]            INT           NOT NULL,
    [idNote]               INT           NULL,
    [created]              DATETIME      NOT NULL,
    [createdBy]            VARCHAR (100) NOT NULL,
    [modified]             DATETIME      NULL,
    [modifiedBy]           VARCHAR (100) NULL,
    CONSTRAINT [PK_WarehouseAdmission] PRIMARY KEY CLUSTERED ([idWarehouseAdmission] ASC),
    CONSTRAINT [FK_WarehouseAdmission_Destiny] FOREIGN KEY ([idDestiny]) REFERENCES [dbo].[Destiny] ([idDestiny]),
    CONSTRAINT [FK_WarehouseAdmission_Material] FOREIGN KEY ([idMaterial]) REFERENCES [dbo].[Material] ([idMaterial]),
    CONSTRAINT [FK_WarehouseAdmission_Note] FOREIGN KEY ([idNote]) REFERENCES [dbo].[Note] ([idNote]),
    CONSTRAINT [FK_WarehouseAdmission_Order] FOREIGN KEY ([idOrder]) REFERENCES [dbo].[Order] ([idOrder]),
    CONSTRAINT [FK_WarehouseAdmission_Supplier] FOREIGN KEY ([idSupplier]) REFERENCES [dbo].[Supplier] ([idSupplier]),
    CONSTRAINT [FK_WarehouseAdmission_Unit] FOREIGN KEY ([idUnit]) REFERENCES [dbo].[Unit] ([idUnit])
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
