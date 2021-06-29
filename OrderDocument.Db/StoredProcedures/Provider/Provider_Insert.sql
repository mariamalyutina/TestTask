create procedure dbo.Provider_Insert
@Name nvarchar(255)
as
Begin
	insert into dbo.[Provider] ([Name])
	values (@Name)
End
