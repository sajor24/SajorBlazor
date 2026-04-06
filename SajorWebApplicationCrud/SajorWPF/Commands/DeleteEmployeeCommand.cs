using System;
using Domain.Models;
using SajorWPF.ViewModels;

namespace SajorWPF.Commands
{
    public class DeleteCommand : BaseCommand
    {
        private readonly AddEmployeeViewModel _viewModel;

        public DeleteCommand(AddEmployeeViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object? parameter)
        {
            if (parameter is Employee employee)
            {
                _viewModel.DeleteEmployee(employee);
            }
        }
    }
}
