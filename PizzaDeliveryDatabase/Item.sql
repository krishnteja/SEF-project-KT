CREATE TABLE [dbo].[Item](
	[ItemId] [int] NOT NULL,
	[ItemName] [varchar](100) NULL,
	[ItemImageUrl] [varchar](100) NULL,
	[Ingredients] [varchar](max) NULL,
	[ItemPrice] [money] NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
