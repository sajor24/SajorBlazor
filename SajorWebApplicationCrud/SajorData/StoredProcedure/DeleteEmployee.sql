CREATE PROCEDURE [dbo].[DeleteEmployee]
    @EmployeeId INT
AS
BEGIN
    DELETE FROM [dbo].[EmployeeTable]
    WHERE EmployeeId = @EmployeeId;
END
