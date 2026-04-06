using System;
using System.Collections.Generic;
using System.Text;
using Framework.Extensions;
using Domain.Models;
using Domain.Commands;
namespace Framework.Commands
{
    public class DeleteCommand : IDeleteCommand
    {
        private readonly Repository _repository;

        public DeleteCommand(Repository repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Employee model)
        {
            var parameters = model.ToDeleteEmployeeDynamicParameters();
            await _repository.SaveDataAsync("DefaultConnection", "[dbo].[DeleteEmployee]", parameters);
        }
    }
}
