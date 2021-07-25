CREATE PROCEDURE [dbo].[GetProductByCategory]
	@categoryId int
AS
BEGIN
	SELECT * FROM [dbo].[products] WHERE [products].[CategoryId] = @categoryId
END
