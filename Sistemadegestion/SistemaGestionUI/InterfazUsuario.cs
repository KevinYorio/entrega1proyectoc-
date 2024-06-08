using System;

namespace SistemaGestionUI
{
    public class InterfazUsuario
    {
        public void MostrarMenuPrincipal()
        {
            Console.WriteLine("Bienvenido al sistema de gestión.");
            Console.WriteLine("1. Gestionar Usuarios");
            Console.WriteLine("2. Gestionar Productos");
            Console.WriteLine("3. Gestionar Ventas");
            Console.WriteLine("4. Salir");
        }

        public void MostrarMenuGestionUsuarios()
        {
            Console.WriteLine("Gestión de Usuarios:");
            Console.WriteLine("1. Listar Usuarios");
            Console.WriteLine("2. Agregar Usuario");
            Console.WriteLine("3. Eliminar Usuario");
            Console.WriteLine("4. Modificar Usuario");
            Console.WriteLine("5. Volver al Menú Principal");
        }

        // Métodos similares para gestionar productos, ventas, etc.

        public void MostrarMensajeError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {mensaje}");
            Console.ResetColor();
        }

        public void MostrarMensajeExito(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Éxito: {mensaje}");
            Console.ResetColor();
        }
    }
}
