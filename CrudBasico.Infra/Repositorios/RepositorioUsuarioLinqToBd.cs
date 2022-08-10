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
            try 
            {
                usuario.Senha = ServicoDeCriptografia.CriptografarSenha(usuario.Senha);
                using (var db = new BancoLinqToBD())
                {
                    db.Insert(usuario);
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public void Atualizar(Usuario usuario)
        {
            try {
                usuario.Senha = ServicoDeCriptografia.CriptografarSenha(usuario.Senha);
                using (var db = new BancoLinqToBD())
                {
                    db.Update(usuario);
                }
            } 
            catch (Exception error) 
            {
                throw new Exception(error.Message);
            } 
        }

        public void Remover(int id)
        {
            try
            {
                using (var db = new BancoLinqToBD())
                {
                    db.Usuario
                            .Where(usuario => usuario.IdUsuario == id)
                            .Delete();
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public List<Usuario> Listar()
        {
            try 
            {
                using (var db = new BancoLinqToBD())
                {
                    var query = from usuario in db.Usuario select usuario;
                    return query.ToList();
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            try 
            {
                using (var db = new BancoLinqToBD())
                {
                    var query = from usuario in db.Usuario
                                where usuario.IdUsuario == id
                                select UsuarioComSenhaDescriptografada(usuario);
                    return query.Single();
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            
        }

        private static Usuario UsuarioComSenhaDescriptografada(Usuario usuario)
        {
            usuario.Senha = ServicoDeCriptografia.DescriptografarSenha(usuario.Senha);
            return usuario;
        }

        public Usuario? BuscarUmUsuarioComEmailRepetido(string email)
        {
            try 
            {
                using (var db = new BancoLinqToBD())
                {
                    var query = from usuario in db.Usuario
                                where usuario.Email == email
                                select usuario;

                    var EmailDoUsuario = query.FirstOrDefault(usuario => usuario.Email == email);

                    return EmailDoUsuario;
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }
    }
}
