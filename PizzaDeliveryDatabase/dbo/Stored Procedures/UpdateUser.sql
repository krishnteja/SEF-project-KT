-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Updates the user information in the user table
-- =============================================
CREATE PROCEDURE [dbo].[UpdateUser] 
	-- Add the parameters for the stored procedure here
	@UserId int =null,
	@Name varchar(100) =null, 
	@Password varchar(100)=null,
	@AddressLine1 varchar(MAX)=null,
	@AddressLine2 varchar(MAX)=null,
	@City varchar(100)=null,
	@Country varchar(100)=null,
	@State varchar(100)=null,
	@ZipCode varchar(100)=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    UPDATE [DeliveryDatabase].[dbo].[User]
   SET[Password] = @Password
      ,[AddressLine1] = @AddressLine1
      ,[AddressLine2] = @AddressLine2
      ,[City] = @City
      ,[Country] = @Country
      ,[ZipCode] = @ZipCode
      ,[State ] = @State
 WHERE (UserId=@UserId) or  (UserId is null and Name=@Name)
	
END