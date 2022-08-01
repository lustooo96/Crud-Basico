namespace Crud_Basico.Modelo
{
    public class Usuario
    {
      
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime DataCriacao { get; set; }

        public Usuario() 
        { 
        }
        public Usuario(int id, string nome, string senha, string email, DateTime? dataNascimento, DateTime dataCriacao)
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


