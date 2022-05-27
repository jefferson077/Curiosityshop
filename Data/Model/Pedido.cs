using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curiosityshop.Data.Model
{
    public class Pedido
    {
        public int Id_pedido { get; set; }
        public int Id_orden { get; set; }
        public string Fecha_pedido { get; set; }
        public string Estado { get; set; }
        public string Fecha_entrega { get; set; }
        public string Direccion_entrega { get; set; }
        public string Ciudad_entrega { get; set; }
        public float Descuento { get; set; }
        public int Cantidad { get; set; }
        public float Total_pedido { get; set; }
        public float Valor_iva { get; set; }
    }
}
