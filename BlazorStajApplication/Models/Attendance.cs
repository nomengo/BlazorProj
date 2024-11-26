namespace BlazorStajApplication.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; } // Çalışan ID
        public Employee Employee { get; set; } // Navigation property
        public DateTime EntryTime { get; set; } // Giriş saati
        public DateTime? ExitTime { get; set; } // Çıkış saati (nullable)
        public bool IsAbsent { get; set; } // Devamsızlık durumu
    }
}
