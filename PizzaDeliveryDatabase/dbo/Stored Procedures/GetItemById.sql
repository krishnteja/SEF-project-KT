-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Gets Item by Id
-- =============================================
CREATE PROCEDURE [dbo].[GetItemById] 
	-- Add the parameters for the stored procedure here
	@ItemId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  [ItemId]
      ,[ItemName]
      ,[ItemImageUrl]
      ,[Ingredients]
      ,[ItemPrice]
      ,[Quantity]
  FROM [DeliveryDatabase].[dbo].[Item] where ItemId=@ItemId
END