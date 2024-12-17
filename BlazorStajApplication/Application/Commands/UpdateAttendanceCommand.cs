namespace BlazorStajApplication.Application.Commands
{
    public class UpdateAttendanceCommand
    {
        public int Id { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime? ExitTime { get; set; }
        public bool IsAbsent { get; set; }
    }
}
