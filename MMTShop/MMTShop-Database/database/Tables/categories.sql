CREATE TABLE [dbo].[categories]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(250) NOT NULL,
	[SkuProductFilter] NVARCHAR(250) NULL -- This filter can be used as the criteria for relating Product SKUs and Categories.
)
