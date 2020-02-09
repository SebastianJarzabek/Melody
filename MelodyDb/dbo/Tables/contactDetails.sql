CREATE TABLE [dbo].[contactDetails] (
    [idContactDetails] INT           IDENTITY (1, 1) NOT NULL,
    [phoneNumber]      VARCHAR (100) NOT NULL,
    [email]            VARCHAR (100) NOT NULL,
    [webside]          VARCHAR (100) NULL,
    CONSTRAINT [PK_contactDetails] PRIMARY KEY CLUSTERED ([idContactDetails] ASC)
);

