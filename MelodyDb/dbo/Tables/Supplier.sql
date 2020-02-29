CREATE TABLE [dbo].[Supplier] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (100) NOT NULL,
    [IdAdress]         INT           NULL,
    [IdContactDetails] INT           NULL,
    CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Supplier_Adress] FOREIGN KEY ([IdAdress]) REFERENCES [dbo].[Adress] ([Id]),
    CONSTRAINT [FK_Supplier_contactDetails] FOREIGN KEY ([IdContactDetails]) REFERENCES [dbo].[contactDetails] ([Id])
);





