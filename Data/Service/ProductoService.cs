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
    public class ProductoService : IProductoService
    {
        //Connecction Sql Server

        private readonly SqlConnectionConfiguration _configuration;

        public ProductoService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }


        public async Task<bool> ProductoInsert(Producto producto)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("Nombre", producto.Nombre_prod, DbType.String);
                parameters.Add("Descripcion", producto.Descripcion_prod, DbType.String);
                parameters.Add("Color", producto.Color_prod, DbType.String);
                parameters.Add("Precio", producto.Precio_prod, DbType.Decimal);
                parameters.Add("Categoria", producto.Categoria_prod, DbType.String);
                parameters.Add("proveedor", producto.Id_vendedor, DbType.Int32);
                parameters.Add("peso", producto.Peso, DbType.Decimal);
                parameters.Add("cantidad", producto.Cantidad, DbType.Int32);
                

                const string query = @"INSERT INTO Producto ( Nombre_prod, Descripcion_prod, Color_prod, Precio_prod, Categoria_prod, Id_vendedor, Peso, Cantidad) VALUES ( @Nombre_prod, @Descripcion_prod, @Color_prod, @Precio_prod, @Categoria_prod, @Id_vendedor, @Peso, @Cantidad)";
                await conn.ExecuteAsync(query, new { producto.Nombre_prod, producto.Descripcion_prod, producto.Color_prod, producto.Precio_prod, producto.Categoria_prod, producto.Id_vendedor, producto.Peso, producto.Cantidad }, commandType: CommandType.Text);
            }
            return true;
        }


        public async Task<IEnumerable<Producto>> GetAllProductos()
        {
            IEnumerable<Producto> producto;

            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string query = "SELECT Id_prod, Nombre_prod, Descripcion_prod, Color_Prod, Precio_Prod, Categoria_prod, Id_vendedor,Peso FROM Producto";
                producto = await conn.QueryAsync<Producto>(query, commandType: CommandType.Text);
            }

            return producto;
        }

    }

    

}
