namespace BlazorStajApplication.Application.Commands
{
    public class UnassignEmployeesFromProjectCommand
    {
        public int ProjectId { get; set; } // Proje ID
        public List<int> EmployeeIds { get; set; } // Unassign edilecek çalışanların ID'leri
    }
}
