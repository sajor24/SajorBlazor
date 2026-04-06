CREATE PROCEDURE [dbo].[ReadEmployeeById]
    @EmployeeId INT
AS
BEGIN
    SELECT *
    FROM [dbo].[EmployeeTable]
    WHERE EmployeeId = @EmployeeId;
END