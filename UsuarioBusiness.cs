using SistemaGestionEntities.models;
using SistemaGestionData.data;
using System.Collections.Generic;

namespace SistemaGestionBusiness
{
    public static class UsuarioBusiness
    {
        public static void Metodo1()
        {
            // Lógica relacionada con usuarios
        }

        public static void CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static void EliminarUsuario(int id)
        {
            UsuarioData.EliminarUsuario(id);
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }
    }
}
