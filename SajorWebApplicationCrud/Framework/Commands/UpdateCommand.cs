using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Domain.Commands;  
using Framework.Extensions;
namespace Framework.Commands
{
        public class UpdateCommand : IUpdateCommand
        {
            private readonly Repository _repository;

            public UpdateCommand(Repository repository)
            {
                _repository = repository;
            }

            public async Task ExecuteAsync(Employee model)
            {
                var parameters = model.ToEmployeeDynamicParameters();
                await _repository.SaveDataAsync("DefaultConnection", "[dbo].[UpdateEmployee]", parameters);
            }
        }
}
