using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetProjectDetailsQueryHandler
    {
        private readonly IProjectRepository _projectRepository;

        public GetProjectDetailsQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Project> Handle(GetProjectDetailsQuery query)
        {
            return await _projectRepository.GetByIdAsync(query.ProjectId);
        }
    }
}
