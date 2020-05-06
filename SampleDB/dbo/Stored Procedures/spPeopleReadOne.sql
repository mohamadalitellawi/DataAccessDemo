CREATE PROCEDURE [dbo].[spPeopleReadOne]
	@Id int
AS

begin
	select [Id], [FirstName], [LastName], [DateOfBirth] 
	from dbo.People
	where Id = @Id;
end
