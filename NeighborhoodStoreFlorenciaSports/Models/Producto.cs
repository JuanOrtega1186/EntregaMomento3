using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeighborhoodStoreFlorenciaSports.Models
{
    public enum Referencia
    {
        Gorra, Tennis, Camisa, Pesas, Colchoneta
    }
    public class Producto
    {
        public int ProductoID { get; set; }
        public int CompraID { get; set; }
        public int ClienteID { get; set; }
        public Referencia? Referencia { get; set; }

        public virtual Compra Compra { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}