CREATE PROCEDURE dbo.OrderDocument_Update
@Id int,
@Date datetime,
@SupplyContractID int,
@StorageID int
as
Begin
	Update dbo.OrderDocument
	Set 
	Date = @Date,
	SupplyContractID = @SupplyContractID,
	StorageID = @StorageID
	where Id = @Id
End
