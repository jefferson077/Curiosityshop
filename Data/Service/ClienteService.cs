using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using Curiosityshop.Data.Model;

namespace Curiosityshop.Data.Service
{
    public class ClienteService : IClienteService
    {
        private readonly SqlConnectionConfiguration _configuration;

        public ClienteService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<IEnumerable<Cliente>> GetAllClients()
        {
            IEnumerable<Cliente> clientes;

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT Id_cliente, Nombreclient, Apellidosclient, Emailclient,Telefonoclient,Direccionclient, Sexo, Ciudad FROM Cliente";
                clientes = await conn.QueryAsync<Cliente>(query, commandType: CommandType.Text);
            }

            return clientes;
        }

       
    }
}