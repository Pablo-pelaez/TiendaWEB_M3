using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda.Models;

namespace Tienda.DAL
{
    public class Inicializador : System.Data.Entity.DropCreateDatabaseIfModelChanges<TiendaContext>
    {
        protected override void Seed(TiendaContext context)
        {
            var clientes = new List<Cliente>
            {
            new Cliente{nombre="Yennifer",numeroTelefono=5789865,numeroCompras=15},
            new Cliente{nombre="David",numeroTelefono=6789865,numeroCompras=10},
            };

            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();

            var compras = new List<Compra>
            {
                new Compra{compraID=1, valorProductos=5000, fechadecompra=DateTime.Parse("2002-05-12")},
                new Compra{compraID=2, valorProductos=6000, fechadecompra=DateTime.Parse("2002-05-12")},
            };
            compras.ForEach(s => context.Compras.Add(s));
            context.SaveChanges();

            var productos = new List<Producto>
            {
                new Producto {productoID=10, nombreProducto="paquete de panela", unidadesDisponibles=21},
                new Producto {productoID=11, nombreProducto="paquete de cafe", unidadesDisponibles=21},
            };
            productos.ForEach(s => context.Productos.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{clienteID=111,compraID=1,productoID=10},
            new Enrollment{clienteID=112,compraID=2,productoID=11},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }

    }
}