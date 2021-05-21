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

USE [EITDEV]

INSERT INTO [dbo].[Cities](Id, Name, Available)
SELECT 1, 'De Kanariske Øer', 1
UNION SELECT 2, 'Marrakesh', 1
UNION SELECT 3, 'Tunis', 1
UNION SELECT 4, 'Tripoli', 1
UNION SELECT 5, 'Sahara', 1
UNION SELECT 6, 'Timbuktu', 1
UNION SELECT 7, 'Dakar', 1
UNION SELECT 8, 'Wadai', 1
UNION SELECT 9, 'Omdurman', 1
UNION SELECT 10, 'Suakin', 1
UNION SELECT 11, 'Kap Guardafui', 1
UNION SELECT 12, 'Addis Abeba', 1
UNION SELECT 13, 'Darfur', 1
UNION SELECT 14, 'Slavekysten', 1
UNION SELECT 15, 'Guldkysten', 1
UNION SELECT 16, 'Sierra Leone', 1
UNION SELECT 17, 'ST. Helena', 1
UNION SELECT 18, 'Luanda', 1
UNION SELECT 19, 'Congo', 1
UNION SELECT 20, 'Kabalo', 1
UNION SELECT 21, 'Bahr El Ghazal', 1
UNION SELECT 22, 'Victoriasøen', 1
UNION SELECT 23, 'Zanzibar', 1
UNION SELECT 24, 'Mocambique', 1
UNION SELECT 25, 'Amatave', 1
UNION SELECT 26, 'Kap St. Marie', 1
UNION SELECT 27, 'Dragebjerget', 1
UNION SELECT 28, 'Victoriafaldene', 1
UNION SELECT 29, 'Hvalbugten', 1
UNION SELECT 30, 'Kapstaden', 1
UNION SELECT 31, 'Tanger', 1
UNION SELECT 32, 'Cairo', 1;

INSERT INTO [dbo].[Edges](Id, Source, Destination, Segments)
SELECT 1, 1, 7, 5
UNION SELECT 2, 7, 1, 5 
UNION SELECT 3, 2, 16, 3   
UNION SELECT 4, 16, 2, 3
UNION SELECT 5, 16, 15, 4
UNION SELECT 6, 15, 16, 4
UNION SELECT 7, 15, 14, 4
UNION SELECT 8, 14, 15, 4
UNION SELECT 9, 15, 29, 11
UNION SELECT 10, 29, 15, 11
UNION SELECT 11, 14, 29, 9
UNION SELECT 12, 29, 14, 9
UNION SELECT 13, 7, 17, 10
UNION SELECT 14, 17, 7, 10
UNION SELECT 15, 17, 30, 9
UNION SELECT 16, 30, 17, 9 
UNION SELECT 17, 29, 30, 3
UNION SELECT 18, 30, 29, 3
UNION SELECT 19, 30, 26, 8
UNION SELECT 20, 26, 30, 8
UNION SELECT 21, 26, 24, 3
UNION SELECT 22, 24, 26, 3
UNION SELECT 23, 24, 11, 8
UNION SELECT 24, 11, 24, 8
UNION SELECT 25, 11, 25, 8
UNION SELECT 26, 25, 11, 8
UNION SELECT 27, 11, 10, 4
UNION SELECT 28, 10, 11, 4
UNION SELECT 29, 10, 32, 4
UNION SELECT 30, 32, 10, 4 
UNION SELECT 31, 32, 3, 5
UNION SELECT 32, 3, 32, 5
UNION SELECT 33, 3, 31, 3
UNION SELECT 34, 31, 3, 3
UNION SELECT 35, 31, 1, 3
UNION SELECT 36, 1, 31, 3;

INSERT INTO [dbo].[ParcelTypes](Id, Type, Supported, Fee)
SELECT 1, 'Live Animals', 1, 25
UNION SELECT 2,'Recorded Delivery', 0, 0
UNION SELECT 3, 'Weapons', 1, 20
UNION SELECT 4, 'Cautious Parcels', 0, 0 
UNION SELECT 5, 'Refrigerated Goods', 1, 10;

INSERT INTO [dbo].[WeightPrices](Id, Minimum, Maximum, Price)
SELECT 1, 0, 10, 8
UNION SELECT 2, 0, 10, 5
UNION SELECT 3, 10, 50, 8 
UNION SELECT 4, 10, 50, 5
UNION SELECT 5, 50, 100, 8 
UNION SELECT 6, 50, 100, 5;

INSERT INTO [dbo].[ParcelStatus](Id, status)
SELECT 1, 'InTransit'
UNION SELECT 2, 'Arrived';

INSERT INTO [dbo].[Roles](Id, Role)
SELECT 1, 'Admin'
UNION SELECT 2, 'PortManager';

INSERT INTO [dbo].[Users](Id, Username, Password, City, Role)
SELECT 1, 'test@dekanariskeøer.dk', 1234, 1, 2
UNION SELECT 2, 'test@slavekysten.dk', 1234, 14, 2
UNION SELECT 3, 'test@hvalbugten.dk', 1234, 29, 2
UNION SELECT 4, 'test@kapstmarie.dk', 1234, 26, 2
UNION SELECT 5, 'test@dakar.dk', 1234, 7, 2
UNION SELECT 6, 'test@sierraleone.dk', 1234, 16, 2 
UNION SELECT 7, 'test@kapstaden.dk', 1234, 30, 2
UNION SELECT 8, 'test@sthelena.dk', 1234, 17, 2
UNION SELECT 9, 'test@kapguardafui.dk', 1234, 11, 2
UNION SELECT 10, 'test@tunis.dk', 1234, 3, 2
UNION SELECT 11, 'admin@admin.dk', 1234, 3, 1;

INSERT INTO [dbo].[ServiceAccounts](Id, organization, APIKey)
SELECT 1, 'TL',' jhflidhfæishfsæohføosjøfllkclkc'
UNION SELECT 2, 'OA', 'ekjfzkfknflsnmglsknmgglkgrs';

