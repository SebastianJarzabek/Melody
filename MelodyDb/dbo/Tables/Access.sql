CREATE TABLE [dbo].[Access] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Login]    VARCHAR (100) NOT NULL,
    [Password] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Access] PRIMARY KEY CLUSTERED ([Id] ASC)
);



