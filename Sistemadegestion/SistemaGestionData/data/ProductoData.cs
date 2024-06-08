using SistemaGestion.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TuNamespace.Models;

namespace TuNamespace.Data
{
    public static class ProductoData
    {
        public static Producto ObtenerProducto(int IdProducto)
        {
            Producto producto = null;
            string query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto WHERE Id=@IdProducto";

            try
            {
                using (SqlConnection conexion = ConnectionADO.GetConnection())
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdProducto", IdProducto);

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    producto = new Producto
                                    {
                                        Id = Convert.ToInt32(dr["Id"]),
                                        Descripciones = dr["Descripciones"].ToString(),
                                        Costo = Convert.ToDecimal(dr["Costo"]),
                                        PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                                        Stock = Convert.ToInt32(dr["Stock"]),
                                        IdUsuario = Convert.ToInt32(dr["IdUsuario"])
                                    };
                                }
                            }
                            else
                            {
                                throw new KeyNotFoundException($"Producto con ID {IdProducto} no encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el producto: " + ex.Message, ex);
            }

            return producto;
        }

    }
}
