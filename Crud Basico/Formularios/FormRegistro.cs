using Crud_Basico.Model;
using Crud_Basico.Services;
using Crud_Basico.Validations;

namespace Crud_Basico
{
    public partial class FormRegistro : Form
    {
        private bool editarRegistro = false;
        public FormRegistro(Usuario usuario)
        {
            InitializeComponent();
            if (usuario != null) CarregarDadosEditarRegistro(usuario);
        }

        private void SalvarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                var formUsuarioValidado = validarFormularioUsuario(textoNome.Text,
                    textoSenha.Text,textoEmail.Text, textoDataNascimento.Text);

                if (!formUsuarioValidado) return;

                DateTime? dataNascimento = textoDataNascimento.Text.Replace("/", "").Trim() != "" ?
                        DateTime.Parse(textoDataNascimento.Text) : null;
                var id = editarRegistro ? Convert.ToInt32(textoId.Text) : ListaUsuario.ContadorDeIndice();
                var dataCriacao = editarRegistro ? DateTime.Parse(textoDataCriacao.Text) : DateTime.Now;

                var usuario = new Usuario(
                        id,
                        textoNome.Text,
                        textoSenha.Text,
                        textoEmail.Text,
                        dataNascimento,
                        dataCriacao);

                
                if (editarRegistro)
                {
                    UsuarioOperacao.EditarRegistroUsuario(usuario);
                }
                else
                {
                    UsuarioOperacao.SalvarRegistroUsuario(usuario);
                }
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message , "Ocorreu um Erro");
            }
        }

        private void CancelarOperacao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarDadosEditarRegistro(Usuario usuario)
        {
            editarRegistro = true;
            textoId.Text = usuario.Id.ToString();
            textoNome.Text = usuario.Nome!.ToString();
            textoSenha.Text = usuario.Senha!.ToString();
            textoDataNascimento.Text = usuario.DataNascimento.ToString();
            textoDataCriacao.Text = usuario.DataCriacao.ToString();
            textoEmail.Text = usuario.Email!.ToString();

            textoId.Visible = true;
            labelId.Visible = true;
            textoDataCriacao.Visible = true;
            labelDataCriacao.Visible = true;
        }
        
        private bool validarFormularioUsuario(string nome, string senha, string email, string data)
        {
            var validarEmail = ValidarEmail(email);
            var validarSenha = Validacao.ValidarSenha(senha);
            var validarNome = Validacao.ValidarNome(nome);
            var validarDataNascimento = Validacao.ValidarDataNascimento(data);


            string mensagemAlertaValidacao = String.Empty;
            mensagemAlertaValidacao += ObterEDefinirErro(validarEmail, erroEmail, textoEmail);
            mensagemAlertaValidacao += ObterEDefinirErro(validarSenha, erroSenha, textoSenha);
            mensagemAlertaValidacao += ObterEDefinirErro(validarNome, erroNome, textoNome);
            mensagemAlertaValidacao += ObterEDefinirErro(validarDataNascimento, erroData, textoDataNascimento);
            
            
            if (mensagemAlertaValidacao != String.Empty)
            {   
                MessageBox.Show(mensagemAlertaValidacao, "Cadastro não finalizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string ObterEDefinirErro((bool validacao, string mensagem) dadosValidacao, ErrorProvider error, Control text)
        {
            if (!dadosValidacao.validacao)
            {
                error.SetError(text, dadosValidacao.mensagem);
                return dadosValidacao.mensagem + "\n";
            }

            return string.Empty;
        }

        private (bool validacao, string messagem) ValidarEmail(string email) 

        {
            var id = editarRegistro ? Convert.ToInt32(textoId.Text) : (int)decimal.Zero;
            var emailPodeSerCriado = ValidacaoUsuario.EmailPodeSerCriado(email, id);
            if (!emailPodeSerCriado.validacao)
            {
                return emailPodeSerCriado;
            }
            return Validacao.ValidarEmail(email);
        }

        private void TextoEmail_TextChanged(object sender, EventArgs e)
        {
            erroEmail.Clear();
        }
        
        private void TextoSenha_TextChanged(object sender, EventArgs e)
        {
            erroSenha.Clear();
        }
        
        private void TextoNome_TextChanged(object sender, EventArgs e)
        {
            erroNome.Clear();
        }
        
        private void TextoDataNascimento_TextChanged(object sender, EventArgs e)
        {
            erroData.Clear();
        }
    }
}
