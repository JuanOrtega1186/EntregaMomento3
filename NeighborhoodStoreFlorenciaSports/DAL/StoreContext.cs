using System.Data.Entity;
using NeighborhoodStoreFlorenciaSports.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NeighborhoodStoreFlorenciaSports.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreContext")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Compra> Compras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}