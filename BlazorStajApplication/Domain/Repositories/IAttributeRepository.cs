using BlazorStajApplication.Domain.Entities;

namespace BlazorStajApplication.Domain.Repositories
{
    public interface IAttributeRepository
    {
        Task<List<EmployeeAttribute>> GetAllByEmployeeIdAsync(int employeeId); // Çalışanın tüm niteliklerini getirir
        Task<EmployeeAttribute> GetByIdAsync(int id); // ID'ye göre nitelik getirir
        Task AddAsync(EmployeeAttribute attribute); // Yeni nitelik ekler
        Task UpdateAsync(EmployeeAttribute attribute); // Mevcut niteliği günceller
        Task DeleteAsync(int id); // Niteliği siler
    }
}
