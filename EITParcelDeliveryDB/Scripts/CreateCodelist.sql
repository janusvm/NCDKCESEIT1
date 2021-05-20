/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

USE [EITParcelDeliveryDB]

INSERT INTO [dbo].[Cities](Id, Name)
SELECT 1, 'De Kanariske Øer'
UNION SELECT 2, 'Marrakesh'
UNION SELECT 3, 'Tunis'
UNION SELECT 4, 'Tripoli'
UNION SELECT 5, 'Sahara'
UNION SELECT 6, 'Timbuktu'
UNION SELECT 7, 'Dakar'
UNION SELECT 8, 'Wadai'
UNION SELECT 9, 'Omdurman'
UNION SELECT 10, 'Suakin'
UNION SELECT 11, 'Kap Guardafui'
UNION SELECT 12, 'Addis Abeba'
UNION SELECT 13, 'Darfur'
UNION SELECT 14, 'Slavekysten'
UNION SELECT 15, 'Guldkysten'
UNION SELECT 16, 'Sierra Leone'
UNION SELECT 17, 'ST. Helena'
UNION SELECT 18, 'Luanda'
UNION SELECT 19, 'Congo'
UNION SELECT 20, 'Kabalo'
UNION SELECT 21, 'Bahr El Ghazal'
UNION SELECT 22, 'Victoriasøen'
UNION SELECT 23, 'Zanzibar'
UNION SELECT 24, 'Mocambique'
UNION SELECT 25, 'Amatave'
UNION SELECT 26, 'Kap St. Marie'
UNION SELECT 27, 'Dragebjerget'
UNION SELECT 28, 'Victoriafaldene'
UNION SELECT 29, 'Hvalbugten'
UNION SELECT 30, 'Kapstaden'
UNION SELECT 31, 'Tanger'
UNION SELECT 32, 'Cairo';


INSERT INTO [dbo].[Edges](Id, Source, Destination, Segments)
SELECT 1, 1, 7, 4
UNION SELECT 2, 1, 3, 4
UNION SELECT 2, 1, 3, 4
