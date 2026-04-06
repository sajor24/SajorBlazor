using Domain.Models;
namespace Domain.Commands
{
    public interface IDeleteCommand
    {
        Task ExecuteAsync(Employee model);

    }
}
