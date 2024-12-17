namespace BlazorStajApplication.Application.Commands
{
    public class AddAttendanceCommand
    {
        public int EmployeeId { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public bool IsAbsent { get; set; }
    }
}
