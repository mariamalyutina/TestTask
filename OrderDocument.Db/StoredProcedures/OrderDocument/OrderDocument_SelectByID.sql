CREATE PROCEDURE dbo.OrderDocument_SelectByID
@OrderDocumentID int
as
Begin
	select OD.Id, OD.Date, S.[Name] as StorageName, P.[Name] as ProviderName, SC.ContractNumber from dbo.OrderDocument as OD
	left join dbo.Storage as S on S.Id = OD.StorageID
	left join dbo.SupplyContract as SC on SC.Id = OD.SupplyContractID
	left join dbo.[Provider] as P on P.Id = SC.ProviderID
	where OD.Id = @OrderDocumentID AND IsDeleted = 0
End
