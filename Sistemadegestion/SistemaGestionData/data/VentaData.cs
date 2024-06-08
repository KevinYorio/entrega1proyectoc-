using SistemaGestion.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TuNamespace.Models;

namespace TuNamespace.Data
{
    public static class VentaData
    {
        public static Venta ObtenerVenta(int IdVenta)
        {
            Venta venta = null;
            string query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id=@IdVenta";

            try
            {
                using (SqlConnection conexion = ConnectionADO.GetConnection())
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdVenta", IdVenta);

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    venta = new Venta
                                    {
                                        Id = Convert.ToInt32(dr["Id"]),
                                        Comentarios = dr["Comentarios"].ToString(),
                                        IdUsuario = Convert.ToInt32(dr["IdUsuario"])
                                    };
                                }
                            }
                            else
                            {
                                throw new KeyNotFoundException($"Venta con ID {IdVenta} no encontrada.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la venta: " + ex.Message, ex);
            }

            return venta;
        }

    }
}
