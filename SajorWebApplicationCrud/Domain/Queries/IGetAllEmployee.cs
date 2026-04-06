using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
namespace Domain.Queries
{
    public interface IGetAllEmployee
    {
        Task<IEnumerable<Employee>?> ExecuteAsync();

    }
}
