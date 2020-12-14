using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NeighborhoodStoreFlorenciaSports.Models;

namespace NeighborhoodStoreFlorenciaSports.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var clientes = new List<Cliente>
            {
            new Cliente{Nombre="Wilson Castro",FechaPedido=DateTime.Parse("2005-09-01")},
            new Cliente{Nombre="Carolina Gomez",FechaPedido=DateTime.Parse("2002-09-01")},
            new Cliente{Nombre="Sebastian Areiza",FechaPedido=DateTime.Parse("2003-09-01")},
            new Cliente{Nombre="Daniel Diaz",FechaPedido=DateTime.Parse("2002-09-01")},
            new Cliente{Nombre="Alejandro Taborda",FechaPedido=DateTime.Parse("2002-09-01")},
            new Cliente{Nombre="Camilo Hernandez",FechaPedido=DateTime.Parse("2001-09-01")},
            new Cliente{Nombre="Gustavo Botero",FechaPedido=DateTime.Parse("2003-09-01")},
            new Cliente{Nombre="Daniel Mira",FechaPedido=DateTime.Parse("2005-09-01")}
            };

            clientes.ForEach(s => context.Clientes.Add(s));
            context.SaveChanges();
            var compras = new List<Compra>
            {
            new Compra{CompraID=1050,Tipo="Efectivo",Costo=300000,},
            new Compra{CompraID=4022,Tipo="A Credito",Costo=250000,},
            new Compra{CompraID=4041,Tipo="Efectivo",Costo=450000,},
            new Compra{CompraID=1045,Tipo="Efectivo",Costo=4000000,},
            new Compra{CompraID=3141,Tipo="Efectivo",Costo=410000,},
            new Compra{CompraID=2021,Tipo="Credito",Costo=150000,},
            new Compra{CompraID=2042,Tipo="Credito",Costo=80000,}
            };
            compras.ForEach(s => context.Compras.Add(s));
            context.SaveChanges();
            var productos = new List<Producto>
            {
            new Producto{ClienteID=1,CompraID=1050,Referencia=Referencia.Tennis},
            new Producto{ClienteID=1,CompraID=4022,Referencia=Referencia.Pesas},
            new Producto{ClienteID=1,CompraID=4041,Referencia=Referencia.Camisa},
            new Producto{ClienteID=2,CompraID=1045,Referencia=Referencia.Camisa},
            new Producto{ClienteID=2,CompraID=3141,Referencia=Referencia.Colchoneta},
            new Producto{ClienteID=2,CompraID=2021,Referencia=Referencia.Colchoneta},
            new Producto{ClienteID=3,CompraID=1050,Referencia=Referencia.Colchoneta},
            new Producto{ClienteID=4,CompraID=1050,Referencia=Referencia.Pesas},
            new Producto{ClienteID=4,CompraID=4022,Referencia=Referencia.Colchoneta},
            new Producto{ClienteID=5,CompraID=4041,Referencia=Referencia.Pesas},
            new Producto{ClienteID=6,CompraID=1045,Referencia=Referencia.Pesas},
            new Producto{ClienteID=7,CompraID=3141,Referencia=Referencia.Tennis},
            };
            productos.ForEach(s => context.Productos.Add(s));
            context.SaveChanges();
        }
    }
}