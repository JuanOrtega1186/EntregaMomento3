using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace NeighborhoodStoreFlorenciaSports.Models
{
    public class Compra
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompraID { get; set; }
        public string Tipo { get; set; }
        public int Costo { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}