CREATE PROCEDURE dbo.OrderDocument_Product_Update
@OrderDocumentId int,
@ProductId int,
@Amount float,
@Price float
as
Begin
	declare @Cost float = @Amount * @Price
	update dbo.OrderDocument_Product 
	set
	Amount = @Amount, 
	Price = @Price,
	Cost = @Cost
	where OrderDocumentID = @OrderDocumentId AND ProductID = @ProductId
End
