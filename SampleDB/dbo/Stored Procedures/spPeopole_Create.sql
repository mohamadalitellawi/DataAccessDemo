CREATE PROCEDURE [dbo].[spPeopole_Create]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@DateOfBirth datetime2(7)
AS
begin
	set nocount on;

	insert into dbo.People(FirstName,LastName,DateOfBirth)
	values(@FirstName,@LastName,@DateOfBirth);
end
