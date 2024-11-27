using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class CreateEmployeeCommandHandler
    {
        private readonly IEmployeeRepository _employeeRepository;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task Handle(CreateEmployeeCommand command)
        {
            var employee = new Employee(command.FirstName, command.LastName, command.Department, command.StartDate);

            // Attributes ekleniyor
            /*
            foreach (var attribute in command.Attributes)
            {
                await _employeeRepository.AddAttributeAsync(employee.Id, attribute.Key, attribute.Value);
            }
            */

            await _employeeRepository.AddAsync(employee);
        }
    }
}
