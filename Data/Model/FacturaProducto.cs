using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curiosityshop.Data.Model
{
    public class FacturaProducto
    {
        public int Id_fp { get; set; }
        public int Id_factura { get; set; }
        public int Id_cliente{ get; set; }
        public int Id_Prod { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public String Cantidad2 { get; set; }
        public String Categoria_prod { get; set; }

    }
}
