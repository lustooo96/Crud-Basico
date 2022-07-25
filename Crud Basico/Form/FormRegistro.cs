using Crud_Basico.Model;
using Crud_Basico.Services;

namespace Crud_Basico
{
    public partial class FormRegistro : Form
    {
        bool editar = false;

        public FormRegistro()
        {
            InitializeComponent();
        }
        public FormRegistro(Usuario usuario)
        {
            InitializeComponent();
            CarregarDados(usuario);
            editar = true;

        }

        private void SalvarRegistro_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                var usuario = new Usuario(
                    Convert.ToInt32(textoId.Text), 
                    textoNome.Text, textoSenha.Text, 
                    textoEmail.Text, 
                    textoDataNascimento.Text,
                     textoDataCriacao.Text);

                UsuarioOperacoes.AlterarRegistro(usuario);
            }
            else
            {
                var usuario = new Usuario(
                    UsuarioAcoes.ContadorDeIncide(), 
                    textoNome.Text, textoSenha.Text, 
                    textoEmail.Text, 
                    textoDataNascimento.Text,
                    DateTime.Now.ToString("dd-MM-yyyy"));
                UsuarioOperacoes.SalvarRegistro(usuario);
            }

            this.Close();
        }

        private void CancelarOperacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarDados(Usuario usuario)
        {
            textoId.Text = usuario.Id.ToString();
            textoNome.Text = usuario.Nome.ToString();
            textoSenha.Text = usuario.Senha.ToString();
            textoDataNascimento.Text = usuario.DataNascimento.ToString();
            textoDataCriacao.Text = usuario.DataCriacao.ToString();
            textoEmail.Text = usuario.Email.ToString();

            textoId.Visible = true;
            labelId.Visible = true;
            textoDataCriacao.Visible = true;
            labelDataCriacao.Visible = true;
        }
    }
}
