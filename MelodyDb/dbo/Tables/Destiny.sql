CREATE TABLE [dbo].[Destiny] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (100) NOT NULL,
    [Contract] INT           NOT NULL,
    CONSTRAINT [PK_Destiny] PRIMARY KEY CLUSTERED ([Id] ASC)
);



