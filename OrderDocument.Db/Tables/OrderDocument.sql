CREATE TABLE [OrderDocument] (
	Id int NOT NULL identity,
	Date datetime NOT NULL,
	SupplyContractID int NOT NULL,
	StorageID int NOT NULL,
	IsDeleted bit NOT NULL DEFAULT '0',
  CONSTRAINT [PK_ORDERDOCUMENT] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
ALTER TABLE [OrderDocument] WITH CHECK ADD CONSTRAINT [OrderDocument_fk0] FOREIGN KEY ([SupplyContractID]) REFERENCES [SupplyContract]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [OrderDocument] CHECK CONSTRAINT [OrderDocument_fk0]
GO
ALTER TABLE [OrderDocument] WITH CHECK ADD CONSTRAINT [OrderDocument_fk1] FOREIGN KEY ([StorageID]) REFERENCES [Storage]([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [OrderDocument] CHECK CONSTRAINT [OrderDocument_fk1]
GO