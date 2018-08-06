-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Gets a user based on Name from the user table
-- =============================================
CREATE PROCEDURE [dbo].[GetUserByName]
	-- Add the parameters for the stored procedure here
	@UserName varchar(100)
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
  FROM [DeliveryDatabase].[dbo].[User] where Name=@UserName
END