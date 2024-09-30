using Microsoft.EntityFrameworkCore;
using SalesWebMvcFrame70.Data;
using SalesWebMvcFrame70.Models;

namespace SalesWebMvcFrame70.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcFrame70Context _context;

        public DepartmentService(SalesWebMvcFrame70Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}