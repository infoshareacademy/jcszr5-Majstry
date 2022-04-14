using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Warsztat.BLL.Models;

namespace Warsztat_v2.Data
{
    public class ServiceContext : IdentityDbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<OrderParts> OrdersParts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Part>().ToTable("Parts");
            modelBuilder.Entity<OrderParts>().ToTable("OrderParts").HasNoKey();
            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder
                .UseSqlServer("Server=localhost;Database=Service;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
