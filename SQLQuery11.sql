CREATE Table [dbo].[Item] (
	[ItemID] INT NOT NULL PRIMARY KEY,
	[ItemName] NVARCHAR(50) NOT NULL,
	[ItemDescription] NVARCHAR(100) NOT NULL,
	[ItemQuantity] INT NOT NULL,
	[Image] IMAGE NOT NULL
);