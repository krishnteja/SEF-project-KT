-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Adds order for a user
-- =============================================
CREATE PROCEDURE [dbo].[AddOrderItems]
	-- Add the parameters for the stored procedure here
	@OrderId int,
	@ItemId int,
	@ItemQuantity int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [DeliveryDatabase].[dbo].[OrderItem]
           ([OrderId]
           ,[ItemId]
           ,[ItemQuantity])
     VALUES
           (@OrderId
           ,@ItemId
           ,@ItemQuantity)
END