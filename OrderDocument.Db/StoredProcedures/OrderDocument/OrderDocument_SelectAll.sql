CREATE PROCEDURE dbo.OrderDocument_SelectAll
as
Begin
	select Id, Date from dbo.OrderDocument
	where IsDeleted = 0
End