using Microsoft.EntityFrameworkCore;
using Negosud_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negosud_MVC.Data
{
    public class NegosudContext : DbContext
    {
        public NegosudContext(DbContextOptions<NegosudContext> options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientCommand> ClientCommands { get; set; }
        public DbSet<ClientCommandLine> ClientCommandLines { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierCommand> SupplierCommands { get; set; }
        public DbSet<SupplierCommandLine> SupplierCommandLines { get; set; }
        public DbSet<Models.Type> Types { get; set; }
    }
}
