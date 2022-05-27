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
    public class DevolucionProductoService : IDevolucionProductoService
    {
        private readonly SqlConnectionConfiguration _configuration;

        public DevolucionProductoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> Productosinsert(DevolucionProducto dproducto)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id_dev", dproducto.Id_dev, DbType.Int32);
                parameters.Add("Id_prod", dproducto.Id_prod, DbType.Int32);
                parameters.Add("Id_factura", dproducto.Id_factura, DbType.Int32);
                parameters.Add("Fecha_dev", dproducto.Fecha_dev, DbType.String);
                parameters.Add("Cantidad", dproducto.Cantidad, DbType.Int32);
                parameters.Add("Motivo", dproducto.Motivo, DbType.String);

                const string query = @"INSERT INTO DevolucionProducto (Id_dev, Id_prod, Id_factura, Fecha_dev,Cantidad,Motivo) VALUES (@Id_dev, @Id_prod, @Id_factura, @Fecha_dev,@Cantidad,@Motivo)";
                await conn.ExecuteAsync(query, new { dproducto.Id_dev, dproducto.Id_prod, dproducto.Id_factura, dproducto.Fecha_dev, dproducto.Cantidad, dproducto.Motivo }, commandType: CommandType.Text);
            }

            return true;
        }

        public async Task<IEnumerable<DevolucionProducto>> GetAllDevProd()
        {
            IEnumerable<DevolucionProducto> devprod;

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT Id_dev,Id_prod,Id_factura,Fecha_dev,Cantidad,Motivo FROM DevolucionProducto";
                devprod = await conn.QueryAsync<DevolucionProducto>(query, commandType: CommandType.Text);
            }

            return devprod;
        }

        public async Task<bool> DevolucionProductoDelete(int Id_dev)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id_dev", Id_dev, DbType.Int32);

                var query = @"DELETE FROM DevolucionProducto
                            WHERE Id_Dev=@Id_Dev";
                await conn.ExecuteAsync(query.ToString(), new { Id_dev }, commandType: CommandType.Text);
            }

            return true;
        }

    }
}
