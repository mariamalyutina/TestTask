CREATE PROCEDURE dbo.OrderDocument_Product_Insert
@OrderDocumentId int,
@ProductId int,
@Amount float,
@Price float
as
Begin
	declare @Cost float = @Amount * @Price
	insert into dbo.OrderDocument_Product (OrderDocumentID, ProductID, Amount, Price, Cost)
	values (@OrderDocumentId, @ProductId, @Amount, @Price, @Cost)
End