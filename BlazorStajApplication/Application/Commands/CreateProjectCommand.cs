namespace BlazorStajApplication.Application.Commands
{
    public class CreateProjectCommand
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Status { get; set; }
    }
}
