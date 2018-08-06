-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Gets Order Items
-- =============================================
CREATE PROCEDURE [dbo].[GetOrderItemsById]
	-- Add the parameters for the stored procedure here
	@OrderId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT OI.[OrderId],
UO.OrderAmount,
      OI.[ItemId]
      ,I.ItemName,
      I.ItemImageUrl,
      I.Ingredients,
      I.ItemPrice
      ,[ItemQuantity]
  FROM [DeliveryDatabase].[dbo].[OrderItem] OI 
  join [DeliveryDatabase].[dbo].Item I on I.ItemId=OI.ItemId
  join [DeliveryDatabase].dbo.UserOrder UO on UO.OrderId=OI.OrderId
  where OI.OrderId=@OrderId
END