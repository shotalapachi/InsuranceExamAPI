using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace InsuranceExamAPI.Models
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Many to One
            modelBuilder.Entity<UserCategory>()
                .HasMany(uc => uc.User)
                .WithOne(u => u.UserCategory)
                .HasForeignKey(uc => uc.UserCategoryId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
