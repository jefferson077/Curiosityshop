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
    public class PedidoService
    {

        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        public PedidoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> PedidoInsert(Pedido pedido)
        {

            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id_pedido", pedido.Id_pedido, DbType.Int32);
                parameters.Add("Id_orden", pedido.Id_orden, DbType.Int32);
                parameters.Add("Fecha_pedido", pedido.Fecha_pedido, DbType.String);
                parameters.Add("Fecha_entrega", pedido.Fecha_entrega, DbType.String);

                const string query = @"INSERT INTO Pedido (Id_pedido, ID_orden, Fecha_pedido, Fecha_entrega) VALUES (@Id_pedido, @ID_orden, @Fecha_pedido, @Fecha_entrega)";
                await conn.ExecuteAsync(query, new { pedido.Id_pedido, pedido.Id_orden, pedido.Fecha_pedido, pedido.Fecha_entrega}, commandType: CommandType.Text);
            }

            return true;
        }
    }
}
