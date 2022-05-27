using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curiosityshop.Data.Model
{
    public class DevolucionProducto
    {
        public int Id_dev { get; set; }
        public int Id_prod { get; set; }
        public int Id_factura { get; set; }
        public string Fecha_dev { get; set; }
        public int Cantidad { get; set; }
        public string Motivo { get; set; }

    }
}
