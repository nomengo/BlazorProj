using BlazorStajApplication.Domain.Entities;

namespace BlazorStajApplication.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task<List<Employee>> GetAllAsync();
        Task DeleteAsync(int id);

        // Attribute eklemek için bir metot
        //Task AddAttributeAsync(int employeeId, string key, string value);

        // Attribute'leri güncellemek veya almak için ek metodlar
        //Task<List<Entities.Attribute>> GetAttributesByEmployeeIdAsync(int employeeId);
    }
}
