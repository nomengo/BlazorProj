using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class UpdateSalaryCommandHandler
    {
        private readonly ISalaryRepository _salaryRepository;

        public UpdateSalaryCommandHandler(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }

        public async Task Handle(UpdateSalaryCommand command)
        {
            var salary = await _salaryRepository.GetByIdAsync(command.Id);

            if (salary == null)
            {
                throw new ArgumentException("Salary record not found.");
            }

            salary.BaseSalary = command.BaseSalary;
            salary.Bonus = command.Bonus;
            salary.Deductions = command.Deductions;
            salary.PaymentDate = command.PaymentDate;

            await _salaryRepository.UpdateAsync(salary);
        }
    }
}
