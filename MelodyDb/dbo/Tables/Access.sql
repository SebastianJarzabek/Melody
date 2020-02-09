CREATE TABLE [dbo].[Access] (
    [idAccess] INT           IDENTITY (1, 1) NOT NULL,
    [login]    VARCHAR (100) NOT NULL,
    [password] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Access] PRIMARY KEY CLUSTERED ([idAccess] ASC)
);

