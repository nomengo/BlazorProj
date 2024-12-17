using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class UpdateAttendanceCommandHandler
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public UpdateAttendanceCommandHandler(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public async Task Handle(UpdateAttendanceCommand command)
        {
            var attendance = await _attendanceRepository.GetByIdAsync(command.Id);

            if (attendance == null)
            {
                throw new ArgumentException("Attendance record not found.");
            }

            attendance.EntryTime = command.EntryTime;
            attendance.ExitTime = command.ExitTime;
            attendance.IsAbsent = command.IsAbsent;

            await _attendanceRepository.UpdateAsync(attendance);
        }
    }
}
