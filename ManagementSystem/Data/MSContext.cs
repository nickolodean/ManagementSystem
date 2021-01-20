using ManagementSystem.Models;
using ManagementSystem.Models.HRIS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Models.MS;
using ManagementSystem.Models.IMS;

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
        public DbSet<Client> Client { get; set; }
        public DbSet<ContactPerson> Contact { get; set; }
        public DbSet<Models.IMS.Action> Action { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Cause> Cause { get; set; }
        public DbSet<Impact> Impact { get; set; }
        public DbSet<Origin> Origin { get; set; }
        public DbSet<RecommendedAction> RecommendedAction { get; set; }
        public DbSet<ReviewStatus> ReviewStatus { get; set; }
        public DbSet<Models.IMS.Type> Type { get; set; }
        public DbSet<TypeCategory> TypeCategory { get; set; }
        public DbSet<ManagementSystem.Models.IMS.InitialReport> InitialReport { get; set; }


    }
}
