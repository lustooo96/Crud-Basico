using Crud_Basico.Model;
using Crud_Basico.Services;

namespace Crud_Basico
{
    public partial class FormRegistro : Form
    {
        private bool editar = false;
        private string emailInicialEditar;
        public FormRegistro()
        {
            InitializeComponent();
            textoDataNascimento.CustomFormat = " ";
        }
        public FormRegistro(Usuario usuario)
        {
            InitializeComponent();
            CarregarDados(usuario);
            textoDataNascimento.CustomFormat = " ";
        }
        private void SalvarRegistro_Click(object sender, EventArgs e)
        {
            var validado = validarFormularioUsuario(textoNome.Text.Trim(), 
                textoSenha.Text.Trim(), 
                textoEmail.Text.Trim());

            if (validado) 
            {
                if (editar)
                {
                    UsuarioOperacao.AlterarRegistro(new Usuario(Convert.ToInt32(textoId.Text),
                        textoNome.Text,
                        textoSenha.Text,
                        textoEmail.Text,
                        textoDataNascimento.Text,
                         textoDataCriacao.Text));
                }
                else
                {
                    UsuarioOperacao.SalvarRegistro(
                         new Usuario(UsuarioAcao.ContadorDeIncide(),
                        textoNome.Text, textoSenha.Text,
                        textoEmail.Text,
                        textoDataNascimento.Text,
                        DateTime.Now.ToString("dd-MM-yyyy")));
                }
                this.Close();
            }
        }
        private void CancelarOperacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarDados(Usuario usuario)
        {
            editar = true;
            emailInicialEditar = usuario.Email;

            textoId.Text = usuario.Id.ToString();
            textoNome.Text = usuario.Nome!.ToString();
            textoSenha.Text = usuario.Senha!.ToString();
            textoDataNascimento.Text = usuario.DataCriacao.ToString();
            textoDataCriacao.Text = usuario.DataCriacao!.ToString();
            textoEmail.Text = usuario.Email!.ToString();

            textoId.Visible = true;
            labelId.Visible = true;
            textoDataCriacao.Visible = true;
            labelDataCriacao.Visible = true;
        }
        private bool validarFormularioUsuario(string nome,string senha, string email)
        {
            var validarEmail = Validacao.ValidarEmail(email);
            var validarSenha = Validacao.ValidarSenha(senha);
            var validarNome = Validacao.ValidarNome(nome);
            if (!validarSenha.validacao || 
                (!validarEmail.validacao &&  !editar || 
                editar && !validarEmail.validacao && emailInicialEditar.ToLower() != email.ToLower()) 
                || !validarNome.validacao)
            {
                string mensagemAlerta = "";
                if (!validarNome.validacao)
                {
                    if (nome == "")
                    {
                        textoNome.Clear();
                    }
                    erroNome.SetError(textoNome, validarNome.messagem);
                    mensagemAlerta += "Campo Nome Inválido \n";
                }
                if (!validarSenha.validacao)
                {
                    if (senha == "")
                    {
                        textoSenha.Clear();
                    }
                    erroSenha.SetError(textoSenha, validarSenha.messagem);
                    mensagemAlerta += "Campo Senha Inválido \n";
                }
                if (!validarEmail.validacao)
                {
                    if (email == "")
                    {
                        textoSenha.Clear();
                    }
                    erroEmail.SetError(textoEmail, validarEmail.messagem);
                    mensagemAlerta += "Campo Email Inválido \n";
                }
              
                MessageBox.Show(mensagemAlerta, "Cadastro não finalizado",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void textoEmail_TextChanged(object sender, EventArgs e)
        {
            erroEmail.Clear();
        }
        private void textoSenha_TextChanged(object sender, EventArgs e)
        {
            erroSenha.Clear();
        }
        private void textoNome_TextChanged(object sender, EventArgs e)
        {
            erroNome.Clear();
        }
        private void textoDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            textoDataNascimento.CustomFormat = "dd/MM/yyyy";
            textoDataNascimento.MinDate = new DateTime(1920, 1, 01);
            textoDataNascimento.MaxDate = DateTime.Today;
        }
    }
}
