using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Toverland_API.Models;

namespace Toverland_API.Data
{
    public class ApplicationDBContext : IdentityDbContext<Account>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }   

        public DbSet<Account> Account { get; set; }
        // public DbSet<Facility> Facility { get; set; }
        // public DbSet<Location> Location { get; set; }
        // public DbSet<MatrixSign> MatrixSign { get; set; }


        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>().ToTable("Account");
            // modelBuilder.Entity<Facility>().ToTable("Facility");
            // modelBuilder.Entity<Location>().ToTable("Location");
            // modelBuilder.Entity<MatrixSign>().ToTable("MatrixSign");
        }
    }
}