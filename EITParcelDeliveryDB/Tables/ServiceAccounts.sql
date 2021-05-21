CREATE TABLE [dbo].[ServiceAccounts]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Organization] VARCHAR(20) NOT NULL,
	[API_Key] VARCHAR(20)
)
