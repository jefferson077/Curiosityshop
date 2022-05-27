using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curiosityshop.Data.Model
{
    public class Producto
    {
        public int Id_prod { get; set; }
        public string Nombre_prod{ get; set; }
        public string Descripcion_prod { get; set; }
        public string Color_prod { get; set; }
        public float Precio_prod{ get; set; }
        public string Categoria_prod{ get; set; }
        public int Id_vendedor { get; set; }
        public float Peso { get; set; }
        public int Cantidad { get; set; }
       
    }
}
