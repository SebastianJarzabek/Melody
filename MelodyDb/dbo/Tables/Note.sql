CREATE TABLE [dbo].[Note] (
    [idNote] INT           IDENTITY (1, 1) NOT NULL,
    [note]   VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Note] PRIMARY KEY CLUSTERED ([idNote] ASC)
);

