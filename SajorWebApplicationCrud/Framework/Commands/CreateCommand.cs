using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.Commands;
using Framework.Extensions;
namespace Framework.Commands
{
    public class CreateCommand : ICreateCommand
    {
            private readonly Repository _repository;

            public CreateCommand(Repository repository)
            {
                _repository = repository;
            }

            public async Task ExecuteAsync(Employee employee)
            {
                var parameters = employee.ToCreateEmployeeDynamicParameters();
                await _repository.SaveDataAsync("DefaultConnection", "[dbo].[CreateEmployee]", parameters);
            }
        }
}
