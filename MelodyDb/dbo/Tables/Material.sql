CREATE TABLE [dbo].[Material] (
    [idMaterial] INT           IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (100) NOT NULL,
    [type]       VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED ([idMaterial] ASC)
);

