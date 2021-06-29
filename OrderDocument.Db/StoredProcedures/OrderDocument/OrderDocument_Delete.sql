CREATE PROCEDURE dbo.OrderDocument_Delete
@Id int
as
Begin
	UPDATE dbo.OrderDocument
	SET
	IsDeleted = 1
	WHERE Id = @Id
End
