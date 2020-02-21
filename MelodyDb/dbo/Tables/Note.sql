CREATE TABLE [dbo].[Note] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Note] VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Note] PRIMARY KEY CLUSTERED ([Id] ASC)
);



