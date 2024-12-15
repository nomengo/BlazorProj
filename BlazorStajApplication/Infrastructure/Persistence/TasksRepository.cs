using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlazorStajApplication.Infrastructure.Persistence
{
    public class TasksRepository : ITasksRepository
    {
        private readonly AppDbContext _context;

        public TasksRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Tasks>> GetAllAsync()
        {
            return await _context.Tasks
                .Include(t => t.AssignedEmployee) // AssignedEmployee'yi dahil et
                .ToListAsync();
        }

        public async Task<Tasks?> GetByIdAsync(int id)
        {
            return await _context.Tasks
                .Include(t => t.AssignedEmployee) // AssignedEmployee'yi dahil et
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        /*
        public async Task<List<Tasks>> GetTasksByEmployeeIdAsync(int employeeId)
        {
            return await _context.Tasks
                .Where(t => t.AssignedEmployeeId == employeeId)
                .ToListAsync();
        }
        */

        public async Task AddAsync(Tasks task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Tasks task)
        {
            _context.Tasks.Update(task);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int taskId)
        {
            var task = await _context.Tasks.FindAsync(taskId);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                await _context.SaveChangesAsync();
            }
        }

    }
}
