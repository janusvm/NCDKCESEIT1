﻿CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Username] VARCHAR(20) NOT NULL,
	[Password] VARCHAR(30) NOT NULL,
	[City] INT FOREIGN KEY REFERENCES [dbo].[Cities](Id)
)
