CREATE TABLE [dbo].[Adress] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Street]          VARCHAR (100) NULL,
    [HouseNumber]     VARCHAR (50)  NULL,
    [ApartmentNumber] VARCHAR (50)  NOT NULL,
    [City]            VARCHAR (50)  NULL,
    [ZipCode]         VARCHAR (50)  NULL,
    [Country]         VARCHAR (50)  NULL,
    CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED ([Id] ASC)
);



