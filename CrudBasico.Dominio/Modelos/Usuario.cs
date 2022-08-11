using LinqToDB.Mapping;

namespace CrudBasico.Dominio.Modelos
{
    [Table(Name = "usuario")]
    public class Usuario
    {
        [Column(Name = "idusuario"), PrimaryKey, Identity]  public int? IdUsuario { get; set; }
        [Column(Name = "nome"), NotNull]  public string Nome { get; set; }
        [Column(Name = "senha"), NotNull]  public string Senha { get; set; }
        [Column(Name = "email"), NotNull]  public string Email { get; set; }
        [Column(Name = "data_nascimento")]  public DateTime? DataNascimento { get; set; }
        [Column(Name = "data_criacao"), NotNull]  public DateTime DataCriacao { get; set; }
         
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


