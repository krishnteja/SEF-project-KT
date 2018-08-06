-- =============================================
-- Author:		Krishna
-- Create date: 07/31/2018
-- Description:	Returns all items and their properties
-- =============================================
CREATE PROCEDURE [dbo].[GetAllItems]
	-- Add the parameters for the stored procedure here
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
  FROM [DeliveryDatabase].[dbo].[Item]
END