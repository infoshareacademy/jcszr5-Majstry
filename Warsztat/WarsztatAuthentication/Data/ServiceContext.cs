﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Part>().ToTable("Parts");
            base.OnModelCreating(modelBuilder);
        }


        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<ServiceContext>(options =>
        //        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        //}
    }
}
