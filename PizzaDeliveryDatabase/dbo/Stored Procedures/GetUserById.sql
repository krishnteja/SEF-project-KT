-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Gets a user based on Id to the user table
-- =============================================
CREATE PROCEDURE [dbo].[GetUserById]
	-- Add the parameters for the stored procedure here
	@UserId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [UserId]
      ,[Name]
      ,[Email]
      ,[Password]
      ,[AddressLine1]
      ,[AddressLine2]
      ,[City]
      ,[Country]
      ,[ZipCode]
      ,[State]
  FROM [DeliveryDatabase].[dbo].[User] where UserId=@UserId
END