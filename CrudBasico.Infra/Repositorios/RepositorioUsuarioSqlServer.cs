﻿using CrudBasico.Dominio.Criptografias;
using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace CrudBasico.Infra.Repositorios
{
    public class RepositorioUsuarioSqlServer : IUsuarioRepositorio
    {
        private string ConexaoString = ("Data Source=INVENT0081\\SQLEXPRESS;Initial Catalog=dados;Integrated Security=true;User ID=sa;Password=Daniela@12");

        public RepositorioUsuarioSqlServer()
        {
        }

        public void Salvar(Usuario usuario)
        {
            if (usuario == null) throw new Exception("O Usuário não foi informado");
            using (SqlConnection conexao = new SqlConnection(ConexaoString))
            {
                conexao.Open();
                string consultarParaSalvarUsuario = @"INSERT INTO dbo.usuario (nome, senha, email, data_nascimento, data_criacao) 
                            VALUES (@Nome, @Senha, @Email, @Data_nascimento , @Data_criacao)";

                using (SqlCommand comando = new SqlCommand(consultarParaSalvarUsuario, conexao))
                {
                    CriarParametrosDoSqlCommandParaUsuario(comando, usuario);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Atualizar(Usuario usuario)
        {
            if (usuario == null) throw new Exception("O Usuário não foi informado");
            using (SqlConnection conexao = new SqlConnection(ConexaoString))
            {
                conexao.Open();
                string consultaParaEditarUsuario = "UPDATE dbo.usuario SET nome =@Nome, senha = @Senha, email = @Email, " +
                                                    "data_nascimento = @Data_nascimento " +
                                                     "WHERE idusuario = @Id";

                using (SqlCommand comando = new SqlCommand(consultaParaEditarUsuario, conexao))
                {
                    CriarParametrosDoSqlCommandParaUsuario(comando, usuario);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Remover(int id)
        {
            if (id == null) throw new Exception("O Id do Usuário não foi informado");
            using (SqlConnection conexao = new SqlConnection(ConexaoString))
            {
                conexao.Open();
                string consultaParaDeletarUsuario = "DELETE FROM dbo.usuario WHERE idusuario = @Id";
                using (SqlCommand comando = new SqlCommand(consultaParaDeletarUsuario, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Usuario> Listar()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            using (SqlConnection conexao = new SqlConnection(ConexaoString))
            {
                conexao.Open();
                string consultaParaListarTodosUsuarios = "SELECT * FROM dbo.usuario";
                using (SqlCommand comando = new SqlCommand(consultaParaListarTodosUsuarios, conexao))
                {
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaUsuarios.Add(CriarUsuarioAtravesDoBanco(reader));
                        }
                    }
                }
            }
            return listaUsuarios.ToList();
        }

        public Usuario BuscarUsuarioPorId(string id)
        {
            Usuario? usuario = null;
            using (SqlConnection conexao = new SqlConnection(ConexaoString))
            {
                string consultaParaBuscarApenasUmUsuario = "SELECT * FROM dbo.usuario WHERE idusuario = @id";
                conexao.Open();
                using (SqlCommand comando = new SqlCommand(consultaParaBuscarApenasUmUsuario, conexao))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        usuario = CriarUsuarioAtravesDoBanco(reader);
                    }
                }
            }
            if (usuario == null)
            {
                string mensagemUsuarioNaoEncontrado = "Não foi encontrado o Usuário com o ID :" + id;
                throw new Exception(mensagemUsuarioNaoEncontrado);
            }
            return usuario;
        }

        private Usuario CriarUsuarioAtravesDoBanco(SqlDataReader reader)
        {
            DateTime? dataNascimentoUsuario = reader.IsDBNull("data_nascimento") ? null : reader.GetDateTime("data_nascimento");
            Usuario usuarioDoBancoDeDados = new Usuario(
                           reader.GetInt32("idusuario"),
                           reader.GetString("nome"),
                           CriptografiaSenha.Descriptografar(reader.GetString("senha")),
                           reader.GetString("email"),
                           dataNascimentoUsuario,
                           reader.GetDateTime("data_criacao"));

            return usuarioDoBancoDeDados;
        }

        private void CriarParametrosDoSqlCommandParaUsuario(SqlCommand comando, Usuario usuario)
        {
            if (usuario.IdUsuario.HasValue)
            {
                comando.Parameters.AddWithValue("@Id", usuario.IdUsuario);
            }
            comando.Parameters.AddWithValue("@Nome", usuario.Nome);
            comando.Parameters.AddWithValue("@Senha", CriptografiaSenha.Criptografar(usuario.Senha));
            comando.Parameters.AddWithValue("@Email", usuario.Email);
            if (usuario.DataNascimento == null)
            {
                comando.Parameters.AddWithValue("@Data_nascimento", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@Data_nascimento", usuario.DataNascimento);
            }
            comando.Parameters.AddWithValue("@Data_criacao", usuario.DataCriacao);
        }
    }
}