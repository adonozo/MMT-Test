CREATE TABLE [dbo].[products]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[CategoryId] INT NOT NULL,
	[Sku] NVARCHAR(250) NOT NULL,
	[Name] NVARCHAR(250) NOT NULL,
	[Description] TEXT NOT NULL, 
    [Price] DECIMAL(10,4) NULL, 
    CONSTRAINT [FK_products_categories] FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id]),

)
