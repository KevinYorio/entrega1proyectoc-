using SistemaGestion.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TuNamespace.Models;

namespace TuNamespace.Data
{
    public static class ProductoVendidoData
    {
        public static ProductoVendido ObtenerProductoVendido(int IdProductoVendido)
        {
            ProductoVendido productoVendido = null;
            string query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido WHERE Id=@IdProductoVendido";

            try
            {
                using (SqlConnection conexion = ConnectionADO.GetConnection())
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdProductoVendido", IdProductoVendido);

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    productoVendido = new ProductoVendido
                                    {
                                        Id = Convert.ToInt32(dr["Id"]),
                                        Stock = Convert.ToInt32(dr["Stock"]),
                                        IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                        IdVenta = Convert.ToInt32(dr["IdVenta"])
                                    };
                                }
                            }
                            else
                            {
                                throw new KeyNotFoundException($"Producto vendido con ID {IdProductoVendido} no encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el producto vendido: " + ex.Message, ex);
            }

            return productoVendido;
        }

    }
}
