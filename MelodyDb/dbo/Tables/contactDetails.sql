CREATE TABLE [dbo].[contactDetails] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [PhoneNumber] VARCHAR (100) NOT NULL,
    [Email]       VARCHAR (100) NOT NULL,
    [Webside]     VARCHAR (100) NULL,
    CONSTRAINT [PK_contactDetails] PRIMARY KEY CLUSTERED ([Id] ASC)
);



