CREATE TABLE [dbo].[WarehouseIssue] (
    [idWarehouseIssue]  INT           IDENTITY (1, 1) NOT NULL,
    [dateOfReceipt]     DATETIME      NOT NULL,
    [receivingEmployee] VARCHAR (100) NOT NULL,
    [hostEmployee]      VARCHAR (100) NOT NULL,
    [idOrder]           INT           NOT NULL,
    [idDestiny]         INT           NOT NULL,
    [idMaterial]        INT           NOT NULL,
    [quantity]          INT           NOT NULL,
    [idUnit]            INT           NOT NULL,
    [idNote]            INT           NULL,
    [created]           DATETIME      NOT NULL,
    [createdBy]         VARCHAR (100) NOT NULL,
    [modified]          DATETIME      NULL,
    [modifiedBy]        VARCHAR (100) NULL,
    CONSTRAINT [PK_WarehouseIssue] PRIMARY KEY CLUSTERED ([idWarehouseIssue] ASC),
    CONSTRAINT [FK_WarehouseIssue_Destiny] FOREIGN KEY ([idDestiny]) REFERENCES [dbo].[Destiny] ([idDestiny]),
    CONSTRAINT [FK_WarehouseIssue_Material] FOREIGN KEY ([idMaterial]) REFERENCES [dbo].[Material] ([idMaterial]),
    CONSTRAINT [FK_WarehouseIssue_Note] FOREIGN KEY ([idNote]) REFERENCES [dbo].[Note] ([idNote]),
    CONSTRAINT [FK_WarehouseIssue_Order] FOREIGN KEY ([idOrder]) REFERENCES [dbo].[Order] ([idOrder]),
    CONSTRAINT [FK_WarehouseIssue_Unit] FOREIGN KEY ([idUnit]) REFERENCES [dbo].[Unit] ([idUnit])
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
