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

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
