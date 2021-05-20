CREATE TABLE [dbo].[PathComponents]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[City] INT FOREIGN KEY REFERENCES [dbo].[Cities](Id) NOT NULL,
	[ArrivedAt] DATETIME,
	[NextDestination] INT FOREIGN KEY REFERENCES [dbo].[PathComponents](Id)
)
