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
    public class FacturaService : IFacturaService
    {
        //Connecction Sql Server

        private readonly SqlConnectionConfiguration _configuration;
        public FacturaService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> FacturaInsert(Factura factura)
        {

            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id_factura", factura.Id_factura, DbType.Int32);
                parameters.Add("Id_cliente", factura.Id_cliente, DbType.Int32);
                parameters.Add("Fecha_Factura", factura.Fecha_Factura, DbType.String);
                parameters.Add("Direccion_entrega", factura.Direccion_entrega, DbType.String);
                parameters.Add("Ciudad_entrega", factura.Ciudad_entrega, DbType.String);
                parameters.Add("Descuento", factura.Descuento, DbType.Decimal);
                parameters.Add("Valor_iva", factura.Valor_iva, DbType.Decimal);
                const string query = @"INSERT INTO Factura (Id_factura, ID_cliente, Fecha_Factura,Estado,Direccion_entrega,Descuento,Total_pedido,Valor_iva) VALUES (@Id_factura, @ID_cliente, @Fecha_Factura,@Estado,@Direccion_entrega,@Descuento,@Total_pedido,@Valor_iva)";
                await conn.ExecuteAsync(query, new { factura.Id_factura, factura.Id_cliente, factura.Fecha_Factura, factura.Direccion_entrega, factura.Descuento, factura.Valor_iva }, commandType: CommandType.Text);
            }

            return true;
        }
        public async Task<Factura> FacturaSelect(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var query = @"SELECT Id_factura, ID_cliente, Fecha_Factura,Direccion_entrega,Ciudad_entrega,Descuento,Valor_iva
                            FROM Factura
                            WHERE Id_Factura = @Id_Factura";
                return await conn.QueryFirstOrDefaultAsync<Factura>(query.ToString(), new { Id_factura = id }, commandType: CommandType.Text);
            }
        }

        public async Task<IEnumerable<Factura>> GetAllFacturas()
        {
            IEnumerable<Factura> facturas;

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT Id_factura ID_cliente, Fecha_Factura,Direccion_entrega,Ciudad_entrega,Descuento,Valor_iva FROM Factura";
                facturas = await conn.QueryAsync<Factura>(query, commandType: CommandType.Text);
            }

            return facturas;
        }

        public async Task<IEnumerable<Devolucion>> GetLastID()
        {
            IEnumerable<Devolucion> devolucion;

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT Id_dev FROM Devolucion WHERE Id_dev=(SELECT max(Id_dev)FROM Devolucion);";
                devolucion = await conn.QueryAsync<Devolucion>(query, commandType: CommandType.Text);
            }

            return devolucion;
        }

        public async Task<int> NumeroFactura()
        {
            var max = 0;
            int cantidad = 0;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                string query = @"SELECT MAX(Id_factura) Numero FROM Factura";
                max = await conn.ExecuteScalarAsync<int>(query, commandType: CommandType.Text);

            }

            cantidad = Convert.ToInt32(max.ToString());
            cantidad++;
            return cantidad;
        }


    }
}

