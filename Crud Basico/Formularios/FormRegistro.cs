using Crud_Basico.Modelo;
using Crud_Basico.Servicos;
using Crud_Basico.Validacoes;

namespace Crud_Basico
{
    public partial class FormRegistro : Form
    {
        UsuarioOperacao OperacaoDoUsuario;
        private bool EditarRegistro = false;
        public FormRegistro(Usuario usuario)
        {
            InitializeComponent();
            if (usuario != null) CarregarDadosParaEditarRegistro(usuario);
            OperacaoDoUsuario = new UsuarioOperacao();
        }

        private void SalvarRegistro_Clicar(object sender, EventArgs e)
        {
            try
            {
                var formUsuarioValidado = ValidarFormularioUsuario(campoEntradaNome.Text,
                    campoEntradaSenha.Text,campoEntradaEmail.Text, campoEntradaDataNascimento.Text);

                if (!formUsuarioValidado) return;

                DateTime? dataNascimento = campoEntradaDataNascimento.Text.Replace("/", "").Trim() != "" ?
                        DateTime.Parse(campoEntradaDataNascimento.Text) : null;
                var id = EditarRegistro ? Convert.ToInt32(campoEntradaId.Text) : ListaUsuario<Usuario>.ReceberNumeroDoIdUsuario();
                var dataCriacao = EditarRegistro ? DateTime.Parse(campoEntradaDataCriacao.Text) : DateTime.Now;

                var usuario = new Usuario(
                        id,
                        campoEntradaNome.Text,
                        campoEntradaSenha.Text,
                        campoEntradaEmail.Text,
                        dataNascimento,
                        dataCriacao);

                
                if (EditarRegistro)
                {
                    OperacaoDoUsuario.Atualizar(usuario);
                }
                else
                {
                    OperacaoDoUsuario.Salvar(usuario);
                }
                this.Close();
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message , "Ocorreu um Erro");
            }
        }

        private void CancelarOperacao_Clicar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarDadosParaEditarRegistro(Usuario usuario)
        {
            EditarRegistro = true;
            campoEntradaId.Text = usuario.Id.ToString();
            campoEntradaNome.Text = usuario.Nome!.ToString();
            campoEntradaSenha.Text = usuario.Senha!.ToString();
            campoEntradaDataNascimento.Text = usuario.DataNascimento.ToString();
            campoEntradaDataCriacao.Text = usuario.DataCriacao.ToString();
            campoEntradaEmail.Text = usuario.Email!.ToString();

            campoEntradaId.Visible = true;
            labelId.Visible = true;
            campoEntradaDataCriacao.Visible = true;
            labelDataCriacao.Visible = true;
        }
        
        private bool ValidarFormularioUsuario(string nome, string senha, string email, string data)
        {
            var validarEmail = ValidarEmail(email);
            var validarSenha = Validacao.ValidarSenha(senha);
            var validarNome = Validacao.ValidarNome(nome);
            var validarDataNascimento = Validacao.ValidarDataNascimento(data);


            string mensagemAlertaValidacao = String.Empty;
            mensagemAlertaValidacao += ObterEDefinirErro(validarEmail, erroEmail, campoEntradaEmail);
            mensagemAlertaValidacao += ObterEDefinirErro(validarSenha, erroSenha, campoEntradaSenha);
            mensagemAlertaValidacao += ObterEDefinirErro(validarNome, erroNome, campoEntradaNome);
            mensagemAlertaValidacao += ObterEDefinirErro(validarDataNascimento, erroData, campoEntradaDataNascimento);
            
            
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
            var id = EditarRegistro ? Convert.ToInt32(campoEntradaId.Text) : (int)decimal.Zero;
            var emailPodeSerCriado = ValidacaoUsuario.EmailPodeSerCriado(email, id);
            if (!emailPodeSerCriado.validacao)
            {
                return emailPodeSerCriado;
            }
            return Validacao.ValidarEmail(email);
        }

        private void CampoDeEntradaEmail_TextoMudar(object sender, EventArgs e)
        {
            erroEmail.Clear();
        }
        
        private void CampoDeEntradaSenha_TextoMudar(object sender, EventArgs e)
        {
            erroSenha.Clear();
        }
        
        private void CampoDeEntradaNome_TextoMudar(object sender, EventArgs e)
        {
            erroNome.Clear();
        }
        
        private void CampoDeEntradaDataNascimento_TextoMudar(object sender, EventArgs e)
        {
            erroData.Clear();
        }
    }
}
