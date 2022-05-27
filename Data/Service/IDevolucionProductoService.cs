using System.Threading.Tasks;
using Curiosityshop.Data.Model;
using System.Collections.Generic;

namespace Curiosityshop.Data.Service
{
    public interface IDevolucionProductoService
    {
        Task<bool> Productosinsert(DevolucionProducto dproducto);
        Task<IEnumerable<DevolucionProducto>> GetAllDevProd();
        Task<bool> DevolucionProductoDelete(int Id_dev);
    }
}