using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Tienda.DAL
{
    public class TiendaContext : DbContext

    {
        public TiendaContext() : base("TiendaContext")
        { }

        public DbSet<Models.Producto> Productos { get; set; }
        public DbSet<Models.Enrollment> Enrollments { get; set; }
        public DbSet<Models.Compra> Compras { get; set; }
        public DbSet<Models.Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}