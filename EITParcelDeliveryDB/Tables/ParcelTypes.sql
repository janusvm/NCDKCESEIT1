CREATE TABLE [dbo].[ParcelTypes]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Type] VARCHAR(50) NOT NULL,
	[Supported] BIT NOT NULL,
	[Fee] INT NOT NULL
)
