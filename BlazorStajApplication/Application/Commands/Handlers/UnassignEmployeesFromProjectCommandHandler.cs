using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class UnassignEmployeesFromProjectCommandHandler
    {
        private readonly IProjectRepository _projectRepository;

        public UnassignEmployeesFromProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task Handle(UnassignEmployeesFromProjectCommand command)
        {
            var project = await _projectRepository.GetByIdAsync(command.ProjectId);

            if (project == null)
            {
                throw new ArgumentException("Project not found.");
            }

            // Çalışanları projeden çıkar
            foreach (var employeeId in command.EmployeeIds)
            {
                var employee = project.Employees.FirstOrDefault(e => e.Id == employeeId);
                if (employee != null)
                {
                    project.Employees.Remove(employee);
                }
            }

            await _projectRepository.UpdateAsync(project);
        }
    }
}
