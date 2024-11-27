using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlazorStajApplication.Infrastructure.Persistence
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _context.Employees
                /*.Include(e => e.Attributes) */// Attributes'i dahil et
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Employee>> GetAllAsync()
        {
            return await _context.Employees
                /*.Include(e => e.Attributes)*/ // Attributes'i dahil et
                .ToListAsync();
        }

        // Attribute ekleme işlemi
        /*public async Task AddAttributeAsync(int employeeId, string key, string value)
        {
            var employee = await _context.Employees.FindAsync(employeeId);
            if (employee != null)
            {
                employee.AddAttribute(key, value);
                await _context.SaveChangesAsync();
            }
        }

        // Employee'nin Attribute'lerini alma işlemi
        public async Task<List<Domain.Entities.Attribute>> GetAttributesByEmployeeIdAsync(int employeeId)
        {
            return await _context.Attributes.Where(a => a.EmployeeId == employeeId).ToListAsync();
        }*/
    }
}
