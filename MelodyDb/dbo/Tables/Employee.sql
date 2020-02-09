CREATE TABLE [dbo].[Employee] (
    [idEmployee]       INT           IDENTITY (1, 1) NOT NULL,
    [name]             VARCHAR (100) NOT NULL,
    [surname]          VARCHAR (100) NOT NULL,
    [department]       VARCHAR (100) NOT NULL,
    [position]         VARCHAR (100) NOT NULL,
    [idAccess]         INT           NOT NULL,
    [idAdress]         INT           NOT NULL,
    [idContactDetails] INT           NOT NULL,
    [created]          DATETIME      NOT NULL,
    [createdBy]        VARCHAR (100) NOT NULL,
    [modified]         DATETIME      NULL,
    [modifiedBy]       VARCHAR (100) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([idEmployee] ASC),
    CONSTRAINT [FK_Employee_Access] FOREIGN KEY ([idAccess]) REFERENCES [dbo].[Access] ([idAccess]),
    CONSTRAINT [FK_Employee_Adress] FOREIGN KEY ([idAdress]) REFERENCES [dbo].[Adress] ([idAdress]),
    CONSTRAINT [FK_Employee_contactDetails] FOREIGN KEY ([idContactDetails]) REFERENCES [dbo].[contactDetails] ([idContactDetails])
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
