using BlazorStajApplication.Domain.Entities;

namespace BlazorStajApplication.Domain.Repositories
{
    public interface IAttendanceRepository
    {
        Task<List<Attendance>> GetAllAsync(); // Tüm kayıtları getirir
        Task<Attendance> GetByIdAsync(int id); // ID'ye göre kayıt getirir
        Task<List<Attendance>> GetByEmployeeIdAsync(int employeeId); // Çalışanın tüm kayıtlarını getirir
        Task AddAsync(Attendance attendance); // Yeni kayıt ekler
        Task UpdateAsync(Attendance attendance); // Kaydı günceller
        Task DeleteAsync(int id); // Kaydı siler
    }
}
