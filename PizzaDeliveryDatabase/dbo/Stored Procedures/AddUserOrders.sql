-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Adds order for a user
-- =============================================
CREATE PROCEDURE [dbo].[AddUserOrders]
	-- Add the parameters for the stored procedure here
	@UserId int,
	@OrderId int,
	@OrderAmount money=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    INSERT INTO [DeliveryDatabase].[dbo].[UserOrder]
           ([UserId]
           ,[OrderId]
           ,[OrderAmount])
     VALUES
           (@UserId
           ,@OrderId
           ,@OrderAmount)
	
END