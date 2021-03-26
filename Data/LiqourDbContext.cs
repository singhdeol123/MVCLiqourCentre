using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MVCLiqourCentre.Models;

namespace MVCLiqourCentre.Data
{
    public class LiqourDbContext : IdentityDbContext
    {
        public LiqourDbContext(DbContextOptions<LiqourDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVCLiqourCentre.Models.Brand> Brand { get; set; }
        public DbSet<MVCLiqourCentre.Models.Product> Product { get; set; }
        public DbSet<MVCLiqourCentre.Models.Wine> Wine { get; set; }
    }
}
