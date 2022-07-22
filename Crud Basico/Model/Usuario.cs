
namespace Crud_Basico.Model
{
    public class Usuario
    {

        public Usuario() 
        { 
        }
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Senha { get; set; }
        public string? Email { get; set; }
        public string? DataNascimento { get; set; }
        public string? DataCriacao { get; set; }

        public Usuario(int id, string nome, string senha, string email, string dataNascimento, string dataCriacao)
        {

            this.Id = id;
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.DataCriacao = dataCriacao;
        }
        

    }
}
