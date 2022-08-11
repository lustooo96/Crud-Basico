using CrudBasico.Dominio.Modelos;
using CrudBasico.Infra.ConexaoLinqToDB;
using CrudBasico.Dominio.Interfaces;
using LinqToDB;
using CrudBasico.Dominio.Servicos;

namespace CrudBasico.Infra.Repositorios
{
    public class RepositorioUsuarioLinqToBd : IUsuarioRepositorio
    {
        private readonly BancoLinqToBD _bancoLinqToDB;
        public RepositorioUsuarioLinqToBd(BancoLinqToBD bancoLinqToBD)
        {
            _bancoLinqToDB = bancoLinqToBD;
        }

        public void Salvar(Usuario usuario)
        {
            try 
            {
                usuario.Senha = ServicoDeCriptografia.CriptografarSenha(usuario.Senha);
                _bancoLinqToDB.Insert(usuario);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                _bancoLinqToDB.Close();
            }
        }

        public void Atualizar(Usuario usuario)
        {
            try
            {
                usuario.Senha = ServicoDeCriptografia.CriptografarSenha(usuario.Senha);
                _bancoLinqToDB.Update(usuario);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally 
            {
                _bancoLinqToDB.Close();
            }
        }

        public void Remover(int id)
        {
            try
            {
                _bancoLinqToDB.Usuario
                        .Where(usuario => usuario.IdUsuario == id)
                        .Delete();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally 
            {
                _bancoLinqToDB.Close();
            }
        }

        public List<Usuario> Listar()
        {
            try 
            {
                var query = from usuario in _bancoLinqToDB.Usuario select usuario;
                return query.ToList();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                _bancoLinqToDB.Close();
            }
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            try 
            {
                var query = from usuario in _bancoLinqToDB.Usuario
                            where usuario.IdUsuario == id
                            select UsuarioComSenhaDescriptografada(usuario);
                return query.Single();  
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                _bancoLinqToDB.Close();
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
                var query = from usuario in _bancoLinqToDB.Usuario
                            where usuario.Email == email
                            select usuario;

                var EmailDoUsuario = query.FirstOrDefault(usuario => usuario.Email == email);

                return EmailDoUsuario;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                _bancoLinqToDB.Close();
            }
        }
    }
}
