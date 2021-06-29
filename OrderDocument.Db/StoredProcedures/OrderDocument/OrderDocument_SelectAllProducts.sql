CREATE PROCEDURE dbo.OrderDocument_SelectAllProducts
@OrderDocumentId int
as
Begin
	select P.[Name], P.StockNumber, P.MeasureUnitID, MU.[Name] as MeasureUnitName, OD_P.Amount, OD_P.Price, OD_P.Cost, P.VatRate from dbo.OrderDocument_Product as OD_P
	left join dbo.Product as P on OD_P.ProductID = P.Id
	left join dbo.MeasureUnits as MU on MU.Id = P.MeasureUnitID
	where OD_P.OrderDocumentID = @OrderDocumentId
End
