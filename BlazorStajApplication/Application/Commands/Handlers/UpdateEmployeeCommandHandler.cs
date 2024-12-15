using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class UpdateEmployeeCommandHandler
    {
        private readonly IEmployeeRepository _repository;

        public UpdateEmployeeCommandHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateEmployeeCommand command)
        {
            var employee = await _repository.GetByIdAsync(command.Id);
            if (employee == null) throw new ArgumentException("Employee not found.");

            employee.FirstName = command.FirstName;
            employee.LastName = command.LastName;
            employee.Department = command.Department;
            employee.StartDate = command.StartDate;

            await _repository.UpdateAsync(employee);
        }
    }
}
