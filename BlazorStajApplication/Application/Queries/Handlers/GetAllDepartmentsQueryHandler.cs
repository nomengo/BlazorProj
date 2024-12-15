using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetAllDepartmentsQueryHandler
    {
        private readonly IDepartmentRepository _departmentRepository;

        public GetAllDepartmentsQueryHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<List<Department>> Handle(GetAllDepartmentsQuery query)
        {
            return await _departmentRepository.GetAllAsync();
        }
    }
}
