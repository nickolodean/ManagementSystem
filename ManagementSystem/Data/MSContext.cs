using ManagementSystem.Models;
using ManagementSystem.Models.HRIS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Data
{
    public class MSContext : DbContext
    {
        public MSContext(DbContextOptions<MSContext> options)
            : base(options)
        {
        }

        // DbSet
        public DbSet<User> User { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeRelative> EmployeeRelative { get; set; }
        public DbSet<Department> Department { get; set; }

    }
}
