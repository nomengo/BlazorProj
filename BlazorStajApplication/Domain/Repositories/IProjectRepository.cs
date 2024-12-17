using BlazorStajApplication.Domain.Entities;

namespace BlazorStajApplication.Domain.Repositories
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync(); // Tüm projeleri getirir
        Task<Project> GetByIdAsync(int projectId); // ID'ye göre proje getirir
        Task AddAsync(Project project); // Yeni bir proje ekler
        Task UpdateAsync(Project project); // Projeyi günceller
        Task DeleteAsync(int projectId); // Projeyi siler
        Task AssignEmployeesToProject(int projectId, List<int> employeeIds); // Çalışanları projeye atar
    }
}
