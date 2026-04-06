using Domain.Models;
namespace Domain.Queries
{
    public interface IReadEmployeeById
    {
        Task<Employee?> ExecuteAsync(int employeeId);

    }
}
