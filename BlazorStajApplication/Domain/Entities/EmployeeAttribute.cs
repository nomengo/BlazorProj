namespace BlazorStajApplication.Domain.Entities
{
    public class EmployeeAttribute
    {
        public int Id { get; set; }
        public string Key { get; set; } // Dinamik nitelik adı
        public string Value { get; set; } // Dinamik nitelik değeri
        public int EmployeeId { get; set; } // İlişkili çalışan ID (EAV için)
        public Employee Employee { get; set; } // Navigation property
    }
}
