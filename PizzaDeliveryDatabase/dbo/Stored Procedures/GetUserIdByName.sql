-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Gets a userId based on Name from the user table
-- =============================================
CREATE PROCEDURE [dbo].[GetUserIdByName]
	-- Add the parameters for the stored procedure here
	@UserName varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [UserId]
      
  FROM [DeliveryDatabase].[dbo].[User] where Name=@UserName
END