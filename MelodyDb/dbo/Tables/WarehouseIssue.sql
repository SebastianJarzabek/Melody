CREATE TABLE [dbo].[WarehouseIssue] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [DateOfReceipt]     DATETIME      NOT NULL,
    [ReceivingEmployee] VARCHAR (100) NOT NULL,
    [HostEmployee]      VARCHAR (100) NOT NULL,
    [IdOrder]           INT           NOT NULL,
    [IdDestiny]         INT           NOT NULL,
    [IdMaterial]   INT           NOT NULL,
    [Quantity]          INT           NOT NULL,
    [IdUnit]            INT           NOT NULL,
    [IdNote]            INT           NULL,
    [Created]           DATETIME      NOT NULL,
    [CreatedBy]         VARCHAR (100) NOT NULL,
    [Modified]          DATETIME      NULL,
    [ModifiedBy]        VARCHAR (100) NULL,
    CONSTRAINT [PK_WarehouseIssue] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_WarehouseIssue_Destiny] FOREIGN KEY ([IdDestiny]) REFERENCES [dbo].[Destiny] ([Id]),
    CONSTRAINT [FK_WarehouseIssue_Material] FOREIGN KEY ([IdMaterial]) REFERENCES [dbo].[Material] ([Id]),
    CONSTRAINT [FK_WarehouseIssue_Note] FOREIGN KEY ([IdNote]) REFERENCES [dbo].[Note] ([Id]),
    CONSTRAINT [FK_WarehouseIssue_Order] FOREIGN KEY ([IdOrder]) REFERENCES [dbo].[Order] ([Id]),
    CONSTRAINT [FK_WarehouseIssue_Unit] FOREIGN KEY ([IdUnit]) REFERENCES [dbo].[Unit] ([Id])
);




GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].WarehouseIssue_Update
   ON  [dbo].WarehouseIssue
   AFTER UPDATE
AS 
BEGIN
	Update [dbo].WarehouseIssue set modified=GETDATE(),
	modifiedBy =SYSTEM_USER
END
