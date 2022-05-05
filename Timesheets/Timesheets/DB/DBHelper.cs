using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.DB
{
    public class DBHelper : DbContext
    {
        public DbSet<PersonDto> Person { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer("Server = localhost; Database = Timesheets; User Id = ; Password = ; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonDto>().Ignore(x => x.Position);
        }
    }
}