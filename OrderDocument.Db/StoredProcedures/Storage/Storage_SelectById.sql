create procedure dbo.Storage_SelectById
@Id int
as
Begin
	select Id, [Name] from dbo.Storage
	where Id = @Id
End

