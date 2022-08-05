namespace CrudBasico.Dominio.Modelos
{
    public class Usuario
    {
      
        public int? IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime DataCriacao { get; set; }

        public Usuario() 
        { 
        }
        public Usuario(int? id, string nome, string senha, string email, DateTime? data_nascimento, DateTime data_criacao)
        {
            this.IdUsuario = id;
            this.Nome = nome;
            this.Senha = senha;
            this.Email = email;
            this.DataNascimento = data_nascimento;
            this.DataCriacao = data_criacao;
        }
    }
}


