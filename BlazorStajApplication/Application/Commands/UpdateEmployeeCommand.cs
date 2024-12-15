namespace BlazorStajApplication.Application.Commands
{
    public class UpdateEmployeeCommand
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
    }
}
