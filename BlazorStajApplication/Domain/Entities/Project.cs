namespace BlazorStajApplication.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } // Proje adı
        public DateTime StartDate { get; set; } // Başlangıç tarihi
        public DateTime? EndDate { get; set; } // Bitiş tarihi (nullable)
        public string Status { get; set; } // Proje durumu (ör. Aktif, Tamamlandı)

        //public int? ResponsibleEmployeeId { get; set; } // Sorumlu çalışan
        //public Employee? ResponsibleEmployee { get; set; } // Navigation property


        // Bir projede birden fazla çalışan olabilir
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
