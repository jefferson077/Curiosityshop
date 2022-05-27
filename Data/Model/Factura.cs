using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curiosityshop.Data.Model
{
    public class Factura
    {
        public int Id_factura { get; set; }
        public int Id_cliente { get; set; }
        public string Fecha_Factura { get; set; }
        public string Direccion_entrega { get; set; }
        public string Ciudad_entrega { get; set; }
        public float Descuento { get; set; }
        public float Valor_iva { get; set; }

    }
}
