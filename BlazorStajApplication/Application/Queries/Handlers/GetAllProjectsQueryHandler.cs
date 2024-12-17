using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetAllProjectsQueryHandler
    {
        private readonly IProjectRepository _projectRepository;

        public GetAllProjectsQueryHandler(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<Project>> Handle(GetAllProjectsQuery query)
        {
            if (query.IncludeEmployees)
            {
                return await _projectRepository.GetAllAsync();
            }
            else
            {
                return await _projectRepository.GetAllAsync();
            }
        }
    }
}
