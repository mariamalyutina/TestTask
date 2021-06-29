CREATE procedure dbo.Provider_SelectById
@Id int
as
Begin
	select Id, [Name] from dbo.[Provider]
	where Id = @Id
End
