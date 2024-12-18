using BlazorStajApplication.Domain.Entities;
using BlazorStajApplication.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlazorStajApplication.Infrastructure.Persistence
{
    public class AttributeRepository : IAttributeRepository
    {
        private readonly AppDbContext _context;

        public AttributeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<EmployeeAttribute>> GetAllByEmployeeIdAsync(int employeeId)
        {
            return await _context.Attributes
                .Where(a => a.EmployeeId == employeeId)
                .ToListAsync();
        }

        public async Task<EmployeeAttribute> GetByIdAsync(int id)
        {
            return await _context.Attributes.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task AddAsync(EmployeeAttribute attribute)
        {
            _context.Attributes.Add(attribute);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(EmployeeAttribute attribute)
        {
            _context.Attributes.Update(attribute);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var attribute = await GetByIdAsync(id);
            if (attribute != null)
            {
                _context.Attributes.Remove(attribute);
                await _context.SaveChangesAsync();
            }
        }
    }
}
