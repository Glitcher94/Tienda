using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda.Models
{
    public class Productos
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Imagen { get; set; }


    }
}