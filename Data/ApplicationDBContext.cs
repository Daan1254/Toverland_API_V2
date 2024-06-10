using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Toverland_API.Models;

namespace Toverland_API.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {
            
        }   

        public DbSet<Account> Account { get; set; }
        // public DbSet<Facility> Facility { get; set; }
        // public DbSet<Location> Location { get; set; }
        // public DbSet<MatrixSign> MatrixSign { get; set; }


    }
}