CREATE PROCEDURE dbo.Product_Insert
@Name nvarchar(50),
@StockNumber nvarchar(30),
@MeasureUnitID int,
@VatRate int
as
Begin
	insert into dbo.Product ([Name], StockNumber, MeasureUnitID, VatRate)
	values (@Name, @StockNumber, @MeasureUnitID, @VatRate)
End
