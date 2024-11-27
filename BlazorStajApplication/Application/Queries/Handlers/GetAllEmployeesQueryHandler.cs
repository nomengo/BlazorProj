using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetAllEmployeesQueryHandler
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetAllEmployeesQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeDto>> Handle(GetAllEmployeesQuery query)
        {
            var employees = await _employeeRepository.GetAllAsync();

            // Verileri DTO'ya dönüştür
            return employees.Select(e => new EmployeeDto
            {
                Id = e.Id,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Department = e.Department,
                StartDate = e.StartDate
                /*
                 ,
                Attributes = e.Attributes.Select(a => new AttributeDto
                {
                    Key = a.Key,
                    Value = a.Value
                }).ToList()
                */
            }).ToList();
        }
    }

    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        //public List<AttributeDto> Attributes { get; set; }
    }

    /*
    public class AttributeDto
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    */
}

