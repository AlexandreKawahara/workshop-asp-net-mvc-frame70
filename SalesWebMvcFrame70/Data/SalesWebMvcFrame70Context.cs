using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvcFrame70.Models;

namespace SalesWebMvcFrame70.Data
{
    public class SalesWebMvcFrame70Context : DbContext
    {
        public SalesWebMvcFrame70Context (DbContextOptions<SalesWebMvcFrame70Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvcFrame70.Models.Department> Department { get; set; } = default!;
    }
}
