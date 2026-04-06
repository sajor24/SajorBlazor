using Dapper;
using Domain.Models;
using Domain.Queries;
namespace Framework.Queries
{
    public class ReadEmployeeById : IReadEmployeeById
    {
        private readonly Repository _repository;

        public ReadEmployeeById(Repository repository)
        {
            _repository = repository;
        }

        public async Task<Employee?> ExecuteAsync(int employeeId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeId", employeeId);

            var data = await _repository.GetDataAsync<Employee>(
                "DefaultConnection",
                "[dbo].[ReadEmployeeById]",
                parameters
            );

            return data?.FirstOrDefault();
        }
    }
}