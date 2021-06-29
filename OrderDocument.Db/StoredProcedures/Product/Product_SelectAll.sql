CREATE PROCEDURE dbo.Product_SelectAll
as
Begin
	select P.Id, P.[Name], P.StockNumber, MU.Id as MeasureUnitID, MU.[Name] as MeasureUnit, P.VatRate from dbo.Product as P
	left join dbo.MeasureUnits as MU on MU.Id = P.MeasureUnitID
End
