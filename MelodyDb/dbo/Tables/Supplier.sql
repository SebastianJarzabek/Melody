CREATE TABLE [dbo].[Supplier] (
    [idSupplier]       INT           IDENTITY (1, 1) NOT NULL,
    [name]             VARCHAR (100) NOT NULL,
    [idAdress]         INT           NOT NULL,
    [idContactDetails] INT           NOT NULL,
    CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED ([idSupplier] ASC),
    CONSTRAINT [FK_Supplier_Adress] FOREIGN KEY ([idAdress]) REFERENCES [dbo].[Adress] ([idAdress]),
    CONSTRAINT [FK_Supplier_contactDetails] FOREIGN KEY ([idContactDetails]) REFERENCES [dbo].[contactDetails] ([idContactDetails])
);

