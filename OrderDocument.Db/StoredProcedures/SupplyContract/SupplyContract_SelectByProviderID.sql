CREATE PROCEDURE dbo.SupplyContract_SelectByProviderID
@ProviderID int
as
Begin
	select P.Id as ProviderId, P.[Name], SC.ContractNumber from dbo.Provider as P
	left join dbo.SupplyContract as SC on SC.ProviderID = P.Id
	where P.Id = @ProviderID
End
