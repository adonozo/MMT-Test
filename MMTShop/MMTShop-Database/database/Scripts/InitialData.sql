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

SET IDENTITY_INSERT [dbo].[categories] ON;
GO

IF NOT EXISTS (SELECT * FROM [dbo].[categories] WHERE [Id] = 1)
    INSERT INTO [dbo].[categories] ([Id],[Name],[SkuProductFilter]) 
    VALUES (1, 'Home', '^1%')

IF NOT EXISTS (SELECT * FROM [dbo].[categories] WHERE [Id] = 2)
    INSERT INTO [dbo].[categories] ([Id],[Name],[SkuProductFilter])
    VALUES (2, 'Garden', '^2%')

IF NOT EXISTS (SELECT * FROM [dbo].[categories] WHERE [Id] = 3)
    INSERT INTO [dbo].[categories] ([Id],[Name],[SkuProductFilter])
    VALUES (3, 'Electronics', '^3%')

IF NOT EXISTS (SELECT * FROM [dbo].[categories] WHERE [Id] = 4)
    INSERT INTO [dbo].[categories] ([Id],[Name],[SkuProductFilter])
    VALUES (4, 'Fitness', '^4%')

IF NOT EXISTS (SELECT * FROM [dbo].[categories] WHERE [Id] = 5)
    INSERT INTO [dbo].[categories] ([Id],[Name],[SkuProductFilter])
    VALUES (5, 'Toys', '^5%')

SET IDENTITY_INSERT [dbo].[categories] OFF;
GO

SET IDENTITY_INSERT [dbo].[products] ON;
GO

IF NOT EXISTS (SELECT * FROM [dbo].[products] WHERE [Id] = 1)
    INSERT INTO [dbo].[products] ([Id],[CategoryId],[Sku],[Name],[Description],[Price],[IsFeatured])
    VALUES (1, 1, '18392', 'Desk Home Office', 'Finished in stylish black for a modern twist', (56.99), 1)

IF NOT EXISTS (SELECT * FROM [dbo].[products] WHERE [Id] = 2)
    INSERT INTO [dbo].[products] ([Id],[CategoryId],[Sku],[Name],[Description],[Price],[IsFeatured])
    VALUES (2, 1, '14823', 'Ergonomic Desk Chair', 'Comfort, function and good looks in one chair', (82.40), 1)

IF NOT EXISTS (SELECT * FROM [dbo].[products] WHERE [Id] = 3)
    INSERT INTO [dbo].[products] ([Id],[CategoryId],[Sku],[Name],[Description],[Price],[IsFeatured])
    VALUES (3, 2, '29470', 'Picnic Table', 'Features a 42 in. x 24 in. table top (almond) with two independent benches (almond) and a folding frame (bronze)', (74.99), 1)

IF NOT EXISTS (SELECT * FROM [dbo].[products] WHERE [Id] = 4)
    INSERT INTO [dbo].[products] ([Id],[CategoryId],[Sku],[Name],[Description],[Price],[IsFeatured])
    VALUES (4, 3, '38847', 'Over Ear Wireless Headphones', 'hanks to the over-ear design, you can block out all the sounds in the house and enjoy your very own viewing of the best blockbusters.', (45.00), 1)

IF NOT EXISTS (SELECT * FROM [dbo].[products] WHERE [Id] = 5)
    INSERT INTO [dbo].[products] ([Id],[CategoryId],[Sku],[Name],[Description],[Price],[IsFeatured])
    VALUES (5, 3, '38561', 'Smart 4K LED TV', 'Crystal display for long-lasting colour & sharp contrast', (480.00), 1)

IF NOT EXISTS (SELECT * FROM [dbo].[products] WHERE [Id] = 6)
    INSERT INTO [dbo].[products] ([Id],[CategoryId],[Sku],[Name],[Description],[Price],[IsFeatured])
    VALUES (6, 4, '40136', 'Yoga Exercise Mat', '10mm thick, the training mat has full padding for extra comfort whilst you train. The cushioned mat reduces pressure on the joints whilst closed cell technology minimises moisture absorption', (29.99), 0)

IF NOT EXISTS (SELECT * FROM [dbo].[products] WHERE [Id] = 7)
    INSERT INTO [dbo].[products] ([Id],[CategoryId],[Sku],[Name],[Description],[Price],[IsFeatured])
    VALUES (7, 5, '59173', 'LEGO Scout Helmet', 'Fully assembled, the Scout Troopers helmet measures over 18cm high, 11cm long and 12cm wide', (33.99), 0)

SET IDENTITY_INSERT [dbo].[products] OFF;
GO