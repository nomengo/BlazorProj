using BlazorStajApplication.Domain.Entities;

namespace BlazorStajApplication.Domain.Repositories
{
    public interface ISalaryRepository
    {
        Task<List<Salary>> GetAllAsync(); // Tüm maaş kayıtlarını getirir
        Task<Salary> GetByIdAsync(int id); // ID'ye göre maaş kaydını getirir
        Task<List<Salary>> GetByEmployeeIdAsync(int employeeId); // Çalışanın maaş kayıtlarını getirir
        Task AddAsync(Salary salary); // Yeni maaş kaydı ekler
        Task UpdateAsync(Salary salary); // Mevcut maaş kaydını günceller
        Task DeleteAsync(int id); // Maaş kaydını siler
    }
}
