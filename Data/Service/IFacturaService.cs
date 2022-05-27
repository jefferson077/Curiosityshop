using System.Threading.Tasks;
using Curiosityshop.Data.Model;
using System.Collections.Generic;

namespace Curiosityshop.Data.Service
{
    public interface IFacturaService
    {
        Task<bool> FacturaInsert(Factura factura);
        Task<Factura> FacturaSelect(int id);
        Task<IEnumerable<Factura>> GetAllFacturas();
        Task<int> NumeroFactura();
    }
}