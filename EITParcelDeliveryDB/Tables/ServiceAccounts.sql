CREATE TABLE [dbo].[ServiceAccounts]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Organization] VARCHAR(50) NOT NULL,
	[APIKey] VARCHAR(50)
)
