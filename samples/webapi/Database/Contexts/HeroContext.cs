using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Contexts
{
    public class HeroContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }

        public HeroContext(DbContextOptions<HeroContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
