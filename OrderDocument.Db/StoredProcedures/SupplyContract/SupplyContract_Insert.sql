CREATE PROCEDURE dbo.SupplyContract_Insert
@ProviderId int,
@ContractNumber nvarchar(20)
as
Begin
	insert into dbo.SupplyContract (ProviderID, ContractNumber)
	values (@ProviderId, @ContractNumber)
End
