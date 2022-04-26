using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.DB
{
    internal sealed class PersonDBContext : DbContext
    {
        public DbSet<PersonDto> Person { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder
            .UseNpgsql("Host=;Database=;Username=;Password=; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonDto>().Ignore(x => x.Comment);

        }
    }
}