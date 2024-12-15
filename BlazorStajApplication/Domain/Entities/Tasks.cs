namespace BlazorStajApplication.Domain.Entities
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; } // Görev adı
        public string Description { get; set; } // Görev tanımı
        public DateTime DueDate { get; set; } // Son teslim tarihi
        public int? AssignedEmployeeId { get; set; } // Sorumlu çalışan
        public Employee? AssignedEmployee { get; set; } // Navigation property
    }
}
