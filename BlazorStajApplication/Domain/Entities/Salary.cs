using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorStajApplication.Domain.Entities
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; } // Çalışan ID
        public Employee Employee { get; set; } // Navigation property
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BaseSalary { get; set; } // Temel maaş
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Bonus { get; set; } // Prim
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Deductions { get; set; } // Kesintiler
        public DateTime PaymentDate { get; set; } // Ödeme tarihi
    }
}
