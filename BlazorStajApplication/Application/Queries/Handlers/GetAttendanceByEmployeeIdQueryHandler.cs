using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;

namespace BlazorStajApplication.Application.Queries.Handlers
{
    public class GetAttendanceByEmployeeIdQueryHandler
    {
        private readonly IAttendanceRepository _attendanceRepository;

        public GetAttendanceByEmployeeIdQueryHandler(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public async Task<List<Attendance>> Handle(GetAttendanceByEmployeeIdQuery query)
        {
            return await _attendanceRepository.GetByEmployeeIdAsync(query.EmployeeId);
        }
    }
}
