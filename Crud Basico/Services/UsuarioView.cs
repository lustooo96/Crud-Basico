using Crud_Basico.Model;


namespace Crud_Basico.Services
{
    class UsuarioView : ListaUsuario
    {
        public static List<Usuario> MostrarUsuarios() 
        {
            return ListaUsuarios.ToList();
        }
    }
}
