using BlazorStajApplication.Domain.Entities;

namespace BlazorStajApplication.Domain.Repositories
{
    public interface ITasksRepository
    {
        Task<List<Tasks>> GetAllAsync();
        Task<Tasks?> GetByIdAsync(int id);
        //Task<List<Tasks>> GetTasksByEmployeeIdAsync(int employeeId);
        Task AddAsync(Tasks task);
        Task UpdateAsync(Tasks task);
        Task DeleteAsync(int id);
    }
}
