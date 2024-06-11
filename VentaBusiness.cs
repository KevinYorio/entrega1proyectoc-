using SistemaGestionEntities.models;
using SistemaGestionData.data;
using System.Collections.Generic;

namespace SistemaGestionBusiness
{
    public static class VentaBusiness
    {
        public static void Metodo1()
        {
            // Lógica relacionada con ventas
        }

        public static void RegistrarVenta(Venta venta)
        {
            VentaData.RegistrarVenta(venta);
        }

        public static List<Venta> ListarVentas()
        {
            return VentaData.ListarVentas();
        }

        public static void EliminarVenta(int id)
        {
            VentaData.EliminarVenta(id);
        }

        public static void ModificarVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }
    }
}
