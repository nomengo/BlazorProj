using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlazorStajApplication.Infrastructure.Persistence
{
    public class SalaryRepository : ISalaryRepository
    {
        private readonly AppDbContext _context;

        public SalaryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Salary>> GetAllAsync()
        {
            return await _context.Salaries
                .Include(s => s.Employee)
                .ToListAsync();
        }

        public async Task<Salary?> GetByIdAsync(int id)
        {
            return await _context.Salaries
                .Include(s => s.Employee)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<List<Salary>> GetByEmployeeIdAsync(int employeeId)
        {
            return await _context.Salaries
                .Include(s => s.Employee)
                .Where(s => s.EmployeeId == employeeId)
                .ToListAsync();
        }

        public async Task AddAsync(Salary salary)
        {
            _context.Salaries.Add(salary);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Salary salary)
        {
            _context.Salaries.Update(salary);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var salary = await GetByIdAsync(id);
            if (salary != null)
            {
                _context.Salaries.Remove(salary);
                await _context.SaveChangesAsync();
            }
        }
    }
}
