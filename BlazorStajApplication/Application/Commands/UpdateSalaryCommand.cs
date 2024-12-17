namespace BlazorStajApplication.Application.Commands
{
    public class UpdateSalaryCommand
    {
        public int Id { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Deductions { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}
