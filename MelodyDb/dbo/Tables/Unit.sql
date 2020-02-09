CREATE TABLE [dbo].[Unit] (
    [idUnit] INT          IDENTITY (1, 1) NOT NULL,
    [name]   VARCHAR (50) NULL,
    CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED ([idUnit] ASC)
);

