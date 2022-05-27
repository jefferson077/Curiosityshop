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
    public class DevolucionService : IDevolucionService
    {
        //Connecction Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        public DevolucionService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> DevolucionInsert(Devolucion devolucion)
        {

            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id_dev", devolucion.Id_dev, DbType.Int32);
                parameters.Add("Fecha_dev", devolucion.Fecha_dev, DbType.String);
                parameters.Add("Id_cliente", devolucion.Id_cliente, DbType.Int32);

                const string query = @"INSERT INTO Devolucion (Id_dev,Id_factura,Fecha_dev,Id_cliente) VALUES (@Id_dev, @Id_factura, @Fecha_dev,@Id_cliente)";
                await conn.ExecuteAsync(query, new { devolucion.Id_dev, devolucion.Fecha_dev,devolucion.Id_cliente}, commandType: CommandType.Text);
            }

            return true;
        }
        public async Task<Devolucion> DevolucionSelect(int id)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var query = @"SELECT Id_Dev,ID_factura,Id_cliente,Fecha_dev,Motivo,Cantidad
                            FROM Devolucion
                            WHERE Id_Devolucion = @Id_Devolucion";
                return await conn.QueryFirstOrDefaultAsync<Devolucion>(query.ToString(), new { Id_devolucion = id }, commandType: CommandType.Text);
            }
        }
        public async Task<bool> DevolucionUpdate(Devolucion devolucion)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id_dev", devolucion.Id_dev, DbType.Int32);
                parameters.Add("Fecha_dev", devolucion.Fecha_dev, DbType.String);
                const string query = @"UPDATE Devolucion 
                    SET ID_dev = @Id_dev, 
                        Fecha_dev = @Fecha_dev
                        Id_factura
                    WHERE Id_Dev=@Id_Dev";
                await conn.ExecuteAsync(query, new { devolucion.Id_dev, devolucion.Fecha_dev}, commandType: CommandType.Text);
            }
            return true;
        }

        public async Task<bool> DevolucionDelete(int Id_dev)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id_dev", Id_dev, DbType.Int32);          

                var query = @"DELETE FROM Devolucion
                            WHERE Id_Dev=@Id_Dev";
                await conn.ExecuteAsync(query.ToString(), new { Id_dev}, commandType: CommandType.Text);
            }

            return true;
        }

        public async Task<IEnumerable<Devolucion>> GetAllDevoluciones()
        {
            IEnumerable<Devolucion> devolucion;

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT Id_dev,Id_cliente,Fecha_dev FROM Devolucion";
                devolucion = await conn.QueryAsync<Devolucion>(query, commandType: CommandType.Text);
            }

            return devolucion;
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
        public async Task<bool> Devolucionadd(Devolucion devolucion)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Id_cliente", devolucion.Id_cliente, DbType.Int32);
                parameters.Add("Fecha_dev", devolucion.Fecha_dev, DbType.DateTime);

                const string query = @"INSERT INTO Devolucion (Id_cliente,Fecha_dev ) VALUES (@Id_cliente,@Fecha_dev)";
                await conn.ExecuteAsync(query, new {devolucion.Id_cliente,devolucion.Fecha_dev}, commandType: CommandType.Text);
            }

            return true;
        }

     }
}
   

