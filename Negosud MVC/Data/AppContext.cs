using Microsoft.EntityFrameworkCore;
using Negosud_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Supplier)> Suppliers { get; set; }
        public DbSet<SupplierCommand> SupplierCommands { get; set; }
        public DbSet<SupplierCommandLine> SupplierCommandLines { get; set; }
    }
}
