-- =============================================
-- Author:		Krishna
-- Create date: 08/01/2018
-- Description:	Adds a user to the user table
-- =============================================
CREATE PROCEDURE [dbo].[AddUser] 
	-- Add the parameters for the stored procedure here
	@Name varchar(100)=null,
	@Email varchar(256)=null,
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
	INSERT INTO [DeliveryDatabase].[dbo].[User]
           ([Name]
           ,[Email]
           ,[Password]
           ,[AddressLine1]
           ,[AddressLine2]
           ,[City]
           ,[Country]
           ,[ZipCode]
           ,[State ])
     VALUES
           (@Name
           ,@Email
           ,@Password
           ,@AddressLine1
           ,@AddressLine2
           ,@City
           ,@Country
           ,@ZipCode
           ,@State)
END