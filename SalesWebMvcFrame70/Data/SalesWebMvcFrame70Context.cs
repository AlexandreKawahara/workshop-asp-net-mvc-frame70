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
        public SalesWebMvcFrame70Context(DbContextOptions<SalesWebMvcFrame70Context> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
    }
}