using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transacciones_en_.net.Models;

namespace Transacciones_en_.net.Data
{
    public class BancoSimple2M5Context : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Cuentas> Cuentas { get; set; }
        public DbSet<Transacciones> Transacciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-B8PH5VV\SQLEXPRESS;Database=BancoSimple2M5;trusted_Connection=true;trustserverCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuentas>().HasQueryFilter(e => e.Estado == true);
        }
    }
}
