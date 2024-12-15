using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class CreateTasksCommandHandler
    {
        private readonly ITasksRepository _taskRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public CreateTasksCommandHandler(ITasksRepository taskRepository, IEmployeeRepository employeeRepository)
        {
            _taskRepository = taskRepository;
            _employeeRepository = employeeRepository;
        }

        public async Task Handle(CreateTasksCommand command)
        {
            // Çalışanın geçerli olup olmadığını kontrol et
            var employee = await _employeeRepository.GetByIdAsync(command.AssignedEmployeeId);
            if (employee == null)
                throw new ArgumentException("Assigned employee not found.");

            var task = new Tasks
            {
                Name = command.Name,
                Description = command.Description,
                DueDate = command.DueDate,
                AssignedEmployeeId = command.AssignedEmployeeId
            };

            await _taskRepository.AddAsync(task);
        }
    }
}
