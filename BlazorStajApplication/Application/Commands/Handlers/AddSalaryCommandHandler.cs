using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class AddSalaryCommandHandler
    {
        private readonly ISalaryRepository _salaryRepository;

        public AddSalaryCommandHandler(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

        public async Task Handle(AddSalaryCommand command)
        {
            var salary = new Salary
            {
                EmployeeId = command.EmployeeId,
                BaseSalary = command.BaseSalary,
                Bonus = command.Bonus,
                Deductions = command.Deductions,
                PaymentDate = command.PaymentDate
            };

            await _salaryRepository.AddAsync(salary);
        }
    }
}
