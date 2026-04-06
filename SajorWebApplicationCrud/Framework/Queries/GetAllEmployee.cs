using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.Queries;
namespace Framework.Queries
{
    public class GetAllEmployee : IGetAllEmployee
    {
        private readonly Repository _repository;

        public GetAllEmployee(Repository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Employee>?> ExecuteAsync()
        {
            return await _repository.GetDataAsync<Employee>("DefaultConnection", "[dbo].[GetAllEmployees]", null);
        }
    }
}
