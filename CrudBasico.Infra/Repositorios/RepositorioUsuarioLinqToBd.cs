using CrudBasico.Dominio.Modelos;
using CrudBasico.Infra.BancoLinqToDB;
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
                usuario.DataCriacao = DateTime.Now;
                usuario.Senha = ServicoDeCriptografia.CriptografarSenha(usuario.Senha);
                _bancoLinqToDB.Insert(usuario);
            }
            catch (Exception error)
            {
                throw new Exception("Não foi possível SALVAR o USUÁRIO");
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
                _bancoLinqToDB.Usuario
                    .Where(usuarioDoBanco => usuarioDoBanco.IdUsuario == usuario.IdUsuario)
                    .Set(usuarioDoBanco => usuarioDoBanco.Nome, usuario.Nome)
                    .Set(usuarioDoBanco => usuarioDoBanco.Senha, usuario.Senha)
                    .Set(usuarioDoBanco => usuarioDoBanco.Email, usuario.Email)
                    .Set(usuarioDoBanco => usuarioDoBanco.DataNascimento, usuario.DataNascimento)
                    .Update();
            }
            catch (Exception error)
            {
                throw new Exception("Não foi possível ATUALIZAR o USUÁRIO");
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
                throw new Exception("Não foi possível REMOVER o Usuário");
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
                var query = from usuario in _bancoLinqToDB.Usuario select new Usuario
                {
                    IdUsuario = usuario.IdUsuario,
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    DataNascimento = usuario.DataNascimento,
                    DataCriacao = usuario.DataCriacao,
                };
                return query.ToList();
            }
            catch (Exception error)
            {
                throw new Exception("Não foi encontrado nenhum USUÁRIO para listar");
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
                            select new Usuario
                            {
                                IdUsuario = usuario.IdUsuario,
                                Nome = usuario.Nome,
                                Email = usuario.Email,
                                DataNascimento = usuario.DataNascimento,
                                DataCriacao = usuario.DataCriacao,
                            };
                return query.Single();  
            }
            catch (Exception error)
            {
                throw new Exception($"Usuário com o ID : {id} , não encontrado");
            }
            finally
            {
                _bancoLinqToDB.Close();
            }
        }
        private static Usuario UsuarioComSenhaDescriptografada(Usuario usuario)
        {
            usuario.Senha = null;
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
                throw new Exception($"O {email} não foi encontrado");
            }
            finally
            {
                _bancoLinqToDB.Close();
            }
        }
    }
}
