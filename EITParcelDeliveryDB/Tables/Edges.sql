CREATE TABLE [dbo].[Edges]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Source] INT FOREIGN KEY REFERENCES [dbo].[Cities](Id) NOT NULL,
	[Destination] INT FOREIGN KEY REFERENCES [dbo].[Cities](Id) NOT NULL,
	[Segments] INT NOT NULL
)
