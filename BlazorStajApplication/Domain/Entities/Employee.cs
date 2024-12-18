namespace BlazorStajApplication.Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } // Çalışanın adı
        public string LastName { get; set; }  // Çalışanın soyadı
        public string Department { get; set; } // Çalışanın bağlı olduğu departman
        public DateTime StartDate { get; set; } // İşe başlama tarihi
        public List<EmployeeAttribute> Attributes { get; set; } // EAV için dinamik nitelikler
                                                        // One-to-Many ilişki
        public int? ProjectId { get; set; } // Foreign Key (nullable)
        public Project? Project { get; set; } // Navigation Property


        public Employee(string firstName, string lastName, string department, DateTime startDate)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentException("Çalışan Ad ve Soyadı Belirtilmelidir!.");

            FirstName = firstName;
            LastName = lastName;
            Department = department;
            StartDate = startDate;
            //Attributes = new List<Attribute>();
        }

        // ProjectId ve Project'i ayarlamak için bir metot 
        public void AssignToProject(Project project)
        {
            if (project == null)
                throw new ArgumentNullException(nameof(project), "Proje null olamaz.");

            ProjectId = project.Id;
            Project = project;
        }

        public void RemoveFromProject()
        {
            ProjectId = null;
            Project = null;
        }

        // Yeni bir dinamik özellik eklemek için metot
        /*
        public void AddAttribute(string key, string value)
        {
            if (Attributes.Any(a => a.Key == key))
                throw new InvalidOperationException($"'{key}' adlı özellik zaten mevcut!");

            Attributes.Add(new Attribute(key, value, Id));
        }

        // Mevcut bir dinamik özelliği güncellemek için metot
        public void UpdateAttribute(string key, string newValue)
        {
            var attribute = Attributes.FirstOrDefault(a => a.Key == key);
            if (attribute == null)
                throw new KeyNotFoundException($"'{key}' adlı özellik bulunamadı!");

            attribute.Value = newValue;
        }
        */

        // Çalışanın bağlı olduğu departmanı değiştirme
        /*
        public void ChangeDepartment(string newDepartment)
        {
            if (string.IsNullOrWhiteSpace(newDepartment))
                throw new ArgumentException("Departman adı boş olamaz!");

            Department = newDepartment;
        }
        */
    }
}
