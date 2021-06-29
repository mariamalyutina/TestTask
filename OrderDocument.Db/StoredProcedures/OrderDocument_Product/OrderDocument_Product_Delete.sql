CREATE PROCEDURE dbo.OrderDocument_Product_Delete
@OrderDocumentId int,
@ProductId int
as
Begin
	delete from dbo.OrderDocument_Product 
	where OrderDocumentID = @OrderDocumentId AND ProductID = @ProductId
End
