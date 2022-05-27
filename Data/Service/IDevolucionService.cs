using System.Threading.Tasks;
using Curiosityshop.Data.Model;
using System.Collections.Generic;

namespace Curiosityshop.Data.Service
{
    public interface IDevolucionService
    {
        Task<bool> DevolucionInsert(Devolucion devolucion);
        Task<IEnumerable<Devolucion>> GetAllDevoluciones();
        Task<Devolucion> DevolucionSelect(int id);
        Task<bool> Devolucionadd(Devolucion devolucion);
        Task<IEnumerable<Devolucion>> GetLastID();
        Task<bool> DevolucionDelete(int Id_dev);
    }
}