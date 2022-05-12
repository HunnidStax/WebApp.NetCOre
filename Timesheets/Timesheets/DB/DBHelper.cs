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
        public DbSet<ClientDto> Client { get; set; }
        public DbSet<ContractDto> Contract { get; set; }
        public DbSet<EmployeeDto> Employee { get; set; }
        public DbSet<InvoicesDto> Invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonDto>().Ignore(x => x.Position);
        }
    }
}