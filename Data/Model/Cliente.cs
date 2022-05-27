using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curiosityshop.Data.Model
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nombreclient { get; set; }
        public string Apellidosclient { get; set; }
        public string Emailclient { get; set; }
        public int Telefonoclient { get; set; }
        public string Direccionclient { get; set; }
        public char Sexo { get; set; }
        public string Ciudad { get; set; }
    }
}
