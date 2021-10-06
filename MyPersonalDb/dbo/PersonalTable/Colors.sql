CREATE TABLE [dbo].[Colors]
(
	[ColorId] INT NOT NULL , 
    [ColorName] NCHAR(10) NULL, 
    CONSTRAINT [PK_Colors] PRIMARY KEY ([ColorId]) 
)

GO

CREATE INDEX [ColorName] ON [dbo].[Colors] ([ColorName])
