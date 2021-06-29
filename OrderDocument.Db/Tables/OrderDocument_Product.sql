CREATE TABLE [OrderDocument_Product] (
	Id int NOT NULL Identity,
	OrderDocumentID int NOT NULL,
	ProductID int NOT NULL,
	Amount float NOT NULL,
	Price float NOT NULL,
	Cost float NOT NULL,
  CONSTRAINT [PK_ORDERDOCUMENT_PRODUCT] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)

GO


ALTER TABLE [OrderDocument_Product] WITH CHECK ADD CONSTRAINT [OrderDocument_Product_fk0] FOREIGN KEY ([OrderDocumentID]) REFERENCES [OrderDocument]([Id])
ON UPDATE NO ACTION
GO
ALTER TABLE [OrderDocument_Product] CHECK CONSTRAINT [OrderDocument_Product_fk0]
GO
ALTER TABLE [OrderDocument_Product] WITH CHECK ADD CONSTRAINT [OrderDocument_Product_fk1] FOREIGN KEY ([ProductID]) REFERENCES [Product]([Id])
ON UPDATE NO ACTION
GO
ALTER TABLE [OrderDocument_Product] CHECK CONSTRAINT [OrderDocument_Product_fk1]
GO
ALTER TABLE [OrderDocument_Product] WITH CHECK ADD CONSTRAINT [UC_OrderDocumentID_ProductID] UNIQUE ([OrderDocumentID], [ProductID])
GO