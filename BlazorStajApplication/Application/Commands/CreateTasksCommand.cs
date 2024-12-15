namespace BlazorStajApplication.Application.Commands
{
    public class CreateTasksCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int AssignedEmployeeId { get; set; }
    }
}
