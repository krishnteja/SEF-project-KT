-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Gets User Orders
-- =============================================
CREATE PROCEDURE [dbo].[GetUserOrders]
	-- Add the parameters for the stored procedure here
	@UserId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT UO.UserId,
       UO.OrderId,
       UO.OrderAmount,
       O.ItemId, O.ItemQuantity,
       I.ItemName, I.ItemImageUrl, I.Ingredients, I.ItemPrice     
  FROM [DeliveryDatabase].[dbo].[UserOrder] UO 
  join [DeliveryDatabase].[dbo].OrderItem O on O.OrderId=UO.OrderId
  join [DeliveryDatabase].[dbo].Item I on I.ItemId=O.ItemId
  where UO.UserId=@UserId
END