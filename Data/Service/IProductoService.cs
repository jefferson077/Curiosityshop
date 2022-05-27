using System.Collections.Generic;
using System.Threading.Tasks;
using Curiosityshop.Data.Model;

namespace Curiosityshop.Data.Service
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetAllProductos();
        Task<bool> ProductoInsert(Producto producto);
    }
}