CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Email] [varchar](256) NULL,
	[Password] [varchar](100) NULL,
	[AddressLine1] [varchar](max) NULL,
	[AddressLine2] [varchar](max) NULL,
	[City] [varchar](100) NULL,
	[Country] [varchar](100) NULL,
	[ZipCode] [varchar](20) NULL,
	[State ] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
