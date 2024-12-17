using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class AssignEmployeesToProjectCommandHandler
    {
        private readonly IProjectRepository _projectRepository;

        public AssignEmployeesToProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task Handle(AssignEmployeesToProjectCommand command)
        {
            await _projectRepository.AssignEmployeesToProject(command.ProjectId, command.EmployeeIds);
        }
    }
}
