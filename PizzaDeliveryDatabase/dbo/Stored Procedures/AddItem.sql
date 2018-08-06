-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Adds Items
-- =============================================
CREATE PROCEDURE [dbo].[AddItem] 
	-- Add the parameters for the stored procedure here
	@ItemId int,
	@ItemName varchar(100),
	@ItemImageUrl varchar(100),
	@Ingredients varchar(MAX),
	@ItemPrice money,
	@Quantity int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [DeliveryDatabase].[dbo].[Item]
           ([ItemId]
           ,[ItemName]
           ,[ItemImageUrl]
           ,[Ingredients]
           ,[ItemPrice]
           ,[Quantity])
     VALUES
           (@ItemId
           ,@ItemName
           ,@ItemImageUrl
           ,@Ingredients
           ,@ItemPrice
           ,@Quantity)
END