using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetEmployeeByIdQueryHandler
    {

        private readonly IEmployeeRepository _repository;

        public GetEmployeeByIdQueryHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        public async Task<EmployeeUpdateDto?> Handle(GetEmployeeByIdQuery query)
        {
            var employee = await _repository.GetByIdAsync(query.EmployeeId);
            if (employee == null) return null;

            return new EmployeeUpdateDto
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Department = employee.Department,
                StartDate = employee.StartDate,
                /*
                Attributes = employee.Attributes.Select(a => new AttributeDto
                {
                    Key = a.Key,
                    Value = a.Value
                })
                .ToList()
                */
            };
        }
    }

    public class EmployeeUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        /*
        public List<AttributeDto> Attributes { get; set; }
        */
    }
    /*
    public class AttributeDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    */
}
