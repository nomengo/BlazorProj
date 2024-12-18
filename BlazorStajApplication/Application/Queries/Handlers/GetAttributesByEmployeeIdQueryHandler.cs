using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetAttributesByEmployeeIdQueryHandler
    {
        private readonly IAttributeRepository _attributeRepository;

        public GetAttributesByEmployeeIdQueryHandler(IAttributeRepository attributeRepository)
        {
            _attributeRepository = attributeRepository;
        }

        public async Task<List<EmployeeAttribute>> Handle(GetAttributesByEmployeeIdQuery query)
        {
            return await _attributeRepository.GetAllByEmployeeIdAsync(query.EmployeeId);
        }
    }
}
