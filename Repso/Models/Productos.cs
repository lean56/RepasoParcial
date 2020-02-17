using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repso.Models
{
    public class Productos
    {
        [Key]
        public int ProductosId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Ganancia { get; set; }
        public decimal Precio { get; set; }
        public Productos()
        {
            ProductosId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;     
        }

    }
}
