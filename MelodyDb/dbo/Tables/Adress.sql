CREATE TABLE [dbo].[Adress] (
    [idAdress]        INT           IDENTITY (1, 1) NOT NULL,
    [street]          VARCHAR (100) NULL,
    [houseNumber]     VARCHAR (50)  NULL,
    [apartmentNumber] VARCHAR (50)  NOT NULL,
    [city]            VARCHAR (50)  NULL,
    [zipCode]         VARCHAR (50)  NULL,
    [country]         VARCHAR (50)  NULL,
    CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED ([idAdress] ASC)
);

