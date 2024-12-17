using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class CreateProjectCommandHandler
    {
        private readonly IProjectRepository _projectRepository;

        public CreateProjectCommandHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task Handle(CreateProjectCommand command)
        {
            var project = new Project
            {
                Name = command.Name,
                StartDate = command.StartDate,
                EndDate = command.EndDate,
                Status = command.Status
            };

            await _projectRepository.AddAsync(project);
        }
    }
}
