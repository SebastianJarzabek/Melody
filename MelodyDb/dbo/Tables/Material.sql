CREATE TABLE [dbo].[Material] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (100) NOT NULL,
    [Type] VARCHAR (100) NULL,
    CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED ([Id] ASC)
);





