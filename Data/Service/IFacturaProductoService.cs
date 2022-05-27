using System.Collections.Generic;
using System.Threading.Tasks;
using Curiosityshop.Data.Model;

namespace Curiosityshop.Data.Service
{
    public interface IFacturaProductoService
    {
        Task<FacturaProducto> FacturaProductoSelect(int id);
        Task<IEnumerable<FacturaProducto>> GetAllFacturasProductos();
        Task<IEnumerable<FacturaProducto>> GetAllFPrecios();
    }
}