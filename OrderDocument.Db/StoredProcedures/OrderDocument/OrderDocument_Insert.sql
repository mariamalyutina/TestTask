CREATE PROCEDURE dbo.OrderDocument_Insert
@Date datetime,
@SupplyContractID int,
@StorageID int
as
Begin
	insert into dbo.OrderDocument (Date, SupplyContractID, StorageID)
	values (@Date, @SupplyContractID, @StorageID)
End
