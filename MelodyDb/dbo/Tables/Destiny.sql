CREATE TABLE [dbo].[Destiny] (
    [idDestiny] INT           IDENTITY (1, 1) NOT NULL,
    [name]      VARCHAR (100) NOT NULL,
    [contract]  INT           NOT NULL,
    CONSTRAINT [PK_Destiny] PRIMARY KEY CLUSTERED ([idDestiny] ASC)
);

