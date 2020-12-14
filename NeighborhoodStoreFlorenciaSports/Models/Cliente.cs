using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeighborhoodStoreFlorenciaSports.Models
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaPedido { get; set; }


        public virtual ICollection<Producto> Productos { get; set; }
    }
}