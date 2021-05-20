CREATE TABLE [dbo].[Parcel]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Type] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[ParcelTypes](Id),
	[Price] INT NOT NULL,
	[Weight] INT NOT NULL,
	[ETA] DATETIME NOT NULL,
	[Start] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[PathComponents](Id),
	[Status] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[ParcelStatus](Id)
)
