CREATE PROCEDURE [dbo].[GetFeaturedProducts]
AS
BEGIN
	SELECT * FROM [dbo].[products] WHERE [IsFeatured] = 1;
END
