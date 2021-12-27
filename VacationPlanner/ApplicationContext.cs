using System;
using Microsoft.EntityFrameworkCore;
using VacationPlanner.Entity.Model;

namespace VacationPlanner.DAL
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<VacationHistory> VacationHistory { get; set; }
        public DbSet<VacationType> VacationTypes { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                var a = 0;
            }
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=otus-planner;User Id=postgres;Password=postgres;");
        }
    }
}
