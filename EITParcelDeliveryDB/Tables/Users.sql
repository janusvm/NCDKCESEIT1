CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Username] VARCHAR(50) NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[City] INT FOREIGN KEY REFERENCES [dbo].[Cities](Id) NOT NULL,
	[Role] INT FOREIGN KEY REFERENCES [dbo].[Roles](Id) NOT NULL
)
