using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlazorStajApplication.Infrastructure.Persistence
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _context;

        public ProjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetAllAsync()
        {
            return await _context.Projects
                .Include(p => p.Employees)
                .ToListAsync();
        }

        public async Task<Project?> GetByIdAsync(int projectId)
        {
            return await _context.Projects
                .Include(p => p.Employees)
                .FirstOrDefaultAsync(p => p.Id == projectId);
        }

        public async Task AddAsync(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Project project)
        {
            _context.Projects.Update(project);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int projectId)
        {
            var project = await GetByIdAsync(projectId);
            if (project != null)
            {
                _context.Projects.Remove(project);
                await _context.SaveChangesAsync();
            }
        }

        public async Task AssignEmployeesToProject(int projectId, List<int> employeeIds)
        {
            var project = await GetByIdAsync(projectId);

            if (project == null)
            {
                throw new ArgumentException("Project not found.");
            }

            // Çalışanları projeden temizle
            project.Employees.Clear();

            // Yeni çalışanları ata
            var employees = await _context.Employees
                .Where(e => employeeIds.Contains(e.Id))
                .ToListAsync();

            foreach (var employee in employees)
            {
                project.Employees.Add(employee);
            }

            await _context.SaveChangesAsync();
        }
    }
}
