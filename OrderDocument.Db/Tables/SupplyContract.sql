CREATE TABLE [SupplyContract] (
	Id int NOT NULL Identity,
	ProviderID int NOT NULL,
	ContractNumber nvarchar(20) NOT NULL UNIQUE,
  CONSTRAINT [PK_SUPPLYCONTRACT] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [SupplyContract] WITH CHECK ADD CONSTRAINT [SupplyContract_fk0] FOREIGN KEY ([ProviderID]) REFERENCES [Provider]([Id])
ON UPDATE NO ACTION
GO
ALTER TABLE [SupplyContract] CHECK CONSTRAINT [SupplyContract_fk0]
GO
