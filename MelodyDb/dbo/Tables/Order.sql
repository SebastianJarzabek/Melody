CREATE TABLE [dbo].[Order] (
    [Id]                   INT           IDENTITY (1, 1) NOT NULL,
    [DateOfOrder]          DATETIME      NOT NULL,
    [OrderingEmployee]     VARCHAR (100) NOT NULL,
    [IdSupplier]           INT           NULL,
    [IdDestiny]            INT           NOT NULL,
    [IdMaterial]           INT           NOT NULL,
    [Quantity]             INT           NOT NULL,
    [IdUnit]               INT           NOT NULL,
    [IdNote]               INT           NULL,
    [ReceivingEmployee]    VARCHAR (100) NULL,
    [PlannedDateOfReceipt] DATETIME      NULL,
    [Created]              DATETIME      NOT NULL,
    [CreatedBy]            VARCHAR (100) NOT NULL,
    [Modified]             DATETIME      NULL,
    [ModifiedBy]           VARCHAR (100) NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Order_Destiny] FOREIGN KEY ([IdDestiny]) REFERENCES [dbo].[Destiny] ([Id]),
    CONSTRAINT [FK_Order_Material] FOREIGN KEY ([IdMaterial]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_Order_Note] FOREIGN KEY ([IdNote]) REFERENCES [dbo].[Note] ([Id]),
    CONSTRAINT [FK_Order_Supplier] FOREIGN KEY ([IdSupplier]) REFERENCES [dbo].[Supplier] ([Id]),
    CONSTRAINT [FK_Order_Unit] FOREIGN KEY ([IdUnit]) REFERENCES [dbo].[Unit] ([Id])
);




GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER  [dbo].[Order_Update]
   ON  dbo.[Order]
   AFTER UPDATE
AS 
BEGIN
	Update [dbo].[Order] set modified=GETDATE(),
	modifiedBy =SYSTEM_USER
	
END
