CREATE TABLE [dbo].[Employee] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (100) NOT NULL,
    [Surname]          VARCHAR (100) NOT NULL,
    [Department]       VARCHAR (100) NOT NULL,
    [Position]         VARCHAR (100) NOT NULL,
    [IdAccess]         INT           NOT NULL,
    [IdAdress]         INT           NOT NULL,
    [IdContactDetails] INT           NOT NULL,
    [Created]          DATETIME      NOT NULL,
    [CreatedBy]        VARCHAR (100) NOT NULL,
    [Modified]         DATETIME      NULL,
    [ModifiedBy]       VARCHAR (100) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employee_Access] FOREIGN KEY ([IdAccess]) REFERENCES [dbo].[Access] ([Id]),
    CONSTRAINT [FK_Employee_Adress] FOREIGN KEY ([IdAdress]) REFERENCES [dbo].[Adress] ([Id]),
    CONSTRAINT [FK_Employee_contactDetails] FOREIGN KEY ([IdContactDetails]) REFERENCES [dbo].[contactDetails] ([Id])
);




GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER [dbo].[Employee_Update]
   ON  dbo.Employee
   AFTER UPDATE
AS 
BEGIN
	Update [dbo].[Employee] set modified=GETDATE(),
	modifiedBy =SYSTEM_USER
	
	end
