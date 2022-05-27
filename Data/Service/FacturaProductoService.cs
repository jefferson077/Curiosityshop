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
    public class FacturaProductoService : IFacturaProductoService
    {
        private readonly SqlConnectionConfiguration _configuration;
        public FacturaProductoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<FacturaProducto> FacturaProductoSelect(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var query = @"SELECT Id_fp, Id_factura,Id_Prod,Precio,Cantidad
                            FROM FacturaProducto
                            WHERE Id_fp = @Id_fp";
                return await conn.QueryFirstOrDefaultAsync<FacturaProducto>(query.ToString(), new { Id_fp = id }, commandType: CommandType.Text);
            }
        }

        public async Task<IEnumerable<FacturaProducto>> GetAllFacturasProductos()
        {
            IEnumerable<FacturaProducto> fproducto;

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT Id_fp, Id_factura,Id_Prod,Id_cliente,Precio,Cantidad,Categoria_prod FROM FacturaProducto";
                fproducto = await conn.QueryAsync<FacturaProducto>(query, commandType: CommandType.Text);
            }

            return fproducto;
        }

        public async Task<IEnumerable<FacturaProducto>> GetAllFPrecios()
        {
            IEnumerable<FacturaProducto> fproducto;

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT Id_fp, Id_factura,Id_Prod,Id_cliente,Precio,Cantidad,Categoria_prod FROM FacturaProducto ORDER BY Precio desc";
                fproducto = await conn.QueryAsync<FacturaProducto>(query, commandType: CommandType.Text);
            }

            return fproducto;
        }
    }
}
