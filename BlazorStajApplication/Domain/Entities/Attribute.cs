namespace BlazorStajApplication.Domain.Entities
{
    public class Attribute
    {
        public int Id { get; set; }
        public string Key { get; set; } // Dinamik nitelik adı
        public string Value { get; set; } // Dinamik nitelik değeri
        public int EmployeeId { get; set; } // İlişkili çalışan ID (EAV için)
        public Employee Employee { get; set; } // Navigation property

        public Attribute(string key, string value, int employeeId)
        {
            if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Özellik Adı ve Değeri boş olamaz!.");

            Key = key;
            Value = value;
            EmployeeId = employeeId;
        }
    }
}
