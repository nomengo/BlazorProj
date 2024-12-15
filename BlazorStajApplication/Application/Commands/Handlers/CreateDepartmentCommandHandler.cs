using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class CreateDepartmentCommandHandler
    {
        private readonly IDepartmentRepository _departmentRepository;

        public CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task Handle(CreateDepartmentCommand command)
        {
            var department = new Department
            {
                Name = command.Name,
                Manager = command.Manager,
                EmployeeCount = command.EmployeeCount
            };

            await _departmentRepository.AddAsync(department);
        }
    }
}
