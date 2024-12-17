namespace BlazorStajApplication.Application.Commands
{
    public class AssignEmployeesToProjectCommand
    {
        public int ProjectId { get; set; }
        public List<int> EmployeeIds { get; set; }
    }
}
