using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetSalariesByEmployeeIdQueryHandler
    {
        private readonly ISalaryRepository _salaryRepository;

        public GetSalariesByEmployeeIdQueryHandler(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

        public async Task<List<Salary>> Handle(GetSalariesByEmployeeIdQuery query)
        {
            return await _salaryRepository.GetByEmployeeIdAsync(query.EmployeeId);
        }

    }
}
