using CrudBasico.Dominio.Modelos;
using CrudBasico.Infra.ConexaoLinqToDB;
using CrudBasico.Dominio.Interfaces;
using LinqToDB;
using CrudBasico.Dominio.Servicos;

namespace CrudBasico.Infra.Repositorios
{
    public class RepositorioUsuarioLinqToBd : IUsuarioRepositorio
    {
        public RepositorioUsuarioLinqToBd() 
        { 
        
        }

        public void Salvar(Usuario usuario)
        {
            usuario.Senha = ServicoDeCriptografia.CriptografarSenha(usuario.Senha);
            using (var db = new BancoLinqToBD())
            {
                db.Insert(usuario);
            }
        }

        public List<Usuario> Listar()
        {
            using (var db = new BancoLinqToBD())
            {
                var query = from usuario in db.Usuario select usuario;
                return query.ToList();
            }
        }

        public void Atualizar(Usuario usuario)
        {   
            usuario.Senha = ServicoDeCriptografia.CriptografarSenha(usuario.Senha);
            using (var db = new BancoLinqToBD())
            {
                db.Update(usuario);
            }
        }

        public Usuario BuscarUmUsuarioComEmailRepetido(string email)
        {
            using (var db = new BancoLinqToBD())
            {
                var query = from usuario in db.Usuario 
                                where usuario.Email == email 
                                select usuario;
                return query as Usuario;
            }
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            using (var db = new BancoLinqToBD())
            {
                var query = from usuario in db.Usuario 
                                where usuario.IdUsuario == id
                                select UsuarioComSenhaDescriptografada(usuario);
                return query.Single();
            }
        }

        public void Remover(int id)
        {
            using (var db = new BancoLinqToBD())
            {
                db.Usuario
                        .Where(usuario => usuario.IdUsuario == id)
                        .Delete();
            }
        }

        private static Usuario UsuarioComSenhaDescriptografada(Usuario usuario)
        {
            usuario.Senha = ServicoDeCriptografia.DescriptografarSenha(usuario.Senha);
            return usuario;
        }
    }
}
