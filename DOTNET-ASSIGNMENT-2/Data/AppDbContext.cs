using DOTNET_ASSIGNMENT_2.Models;
using Microsoft.EntityFrameworkCore;

namespace DOTNET_ASSIGNMENT_2.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>()
                 .HasOne(e => e.Department)
                 .WithMany()
                 .HasForeignKey(e => e.Dept_Id)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
