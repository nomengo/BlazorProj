namespace BlazorStajApplication.Domain.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } // Departman adı
        public string Manager { get; set; } // Yöneticisi
        public int EmployeeCount { get; set; } // Çalışan sayısı
    }
}
