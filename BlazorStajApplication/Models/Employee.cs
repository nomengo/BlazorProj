namespace BlazorStajApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } // Çalışanın adı
        public string LastName { get; set; }  // Çalışanın soyadı
        public string Department { get; set; } // Çalışanın bağlı olduğu departman
        public DateTime StartDate { get; set; } // İşe başlama tarihi
        public List<Attribute> Attributes { get; set; } // EAV için dinamik nitelikler
    }
}
