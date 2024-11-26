namespace BlazorStajApplication.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; } // Çalışan ID
        public Employee Employee { get; set; } // Navigation property
        public decimal BaseSalary { get; set; } // Temel maaş
        public decimal Bonus { get; set; } // Prim
        public decimal Deductions { get; set; } // Kesintiler
        public DateTime PaymentDate { get; set; } // Ödeme tarihi
    }
}
