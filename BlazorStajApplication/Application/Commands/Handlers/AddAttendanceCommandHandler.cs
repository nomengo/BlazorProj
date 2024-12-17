using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Commands.Handlers
{
    public class AddAttendanceCommandHandler
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public AddAttendanceCommandHandler(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public async Task Handle(AddAttendanceCommand command)
        {
            var attendance = new Attendance
            {
                EmployeeId = command.EmployeeId,
                EntryTime = command.EntryTime,
                ExitTime = command.ExitTime,
                IsAbsent = command.IsAbsent
            };

            await _attendanceRepository.AddAsync(attendance);
        }
    }
}
