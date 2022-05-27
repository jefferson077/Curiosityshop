using System.Collections.Generic;
using System.Threading.Tasks;
using Curiosityshop.Data.Model;

namespace Curiosityshop.Data.Service
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> GetAllClients();
    }
}