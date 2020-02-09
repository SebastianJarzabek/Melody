CREATE TABLE [dbo].[Order] (
    [idOrder]              INT           IDENTITY (1, 1) NOT NULL,
    [dateOfOrder]          DATETIME      NOT NULL,
    [orderingEmployee]     VARCHAR (100) NOT NULL,
    [idSupplier]           INT           NULL,
    [idDestiny]            INT           NOT NULL,
    [idMaterial]           INT           NOT NULL,
    [quantity]             INT           NOT NULL,
    [idUnit]               INT           NOT NULL,
    [idNote]               INT           NULL,
    [receivingEmployee]    VARCHAR (100) NULL,
    [plannedDateOfReceipt] DATETIME      NULL,
    [created]              DATETIME      NOT NULL,
    [createdBy]            VARCHAR (100) NOT NULL,
    [modified]             DATETIME      NULL,
    [modifiedBy]           VARCHAR (100) NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([idOrder] ASC),
    CONSTRAINT [FK_Order_Destiny] FOREIGN KEY ([idDestiny]) REFERENCES [dbo].[Destiny] ([idDestiny]),
    CONSTRAINT [FK_Order_Material] FOREIGN KEY ([idMaterial]) REFERENCES [dbo].[Material] ([idMaterial]),
    CONSTRAINT [FK_Order_Note] FOREIGN KEY ([idNote]) REFERENCES [dbo].[Note] ([idNote]),
    CONSTRAINT [FK_Order_Supplier] FOREIGN KEY ([idSupplier]) REFERENCES [dbo].[Supplier] ([idSupplier]),
    CONSTRAINT [FK_Order_Unit] FOREIGN KEY ([idUnit]) REFERENCES [dbo].[Unit] ([idUnit])
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
