using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;
using CrudBasico.Dominio.Validacoes;
using FluentValidation;
using FluentValidation.Results;

namespace CrudBasico
{
    public partial class FormRegistro : Form
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IValidator<Usuario> _usarioValidador;
        private bool EditarRegistro = false;

        public FormRegistro(Usuario usuario, IUsuarioRepositorio usuarioRepositorio,IValidator<Usuario> usarioValidador)
        {
            InitializeComponent();
            _usuarioRepositorio = usuarioRepositorio;
            _usarioValidador = usarioValidador;
            if (usuario != null) CarregarDadosParaEditarRegistro(usuario);
        }

        private void AoClicarEmSalvarRegistro(object sender, EventArgs e)
        {
            try
            {
                DateTime? dataNascimento = campoEntradaDataNascimento.Text.Replace("/", "").Trim() != "" ?
                       DateTime.Parse(campoEntradaDataNascimento.Text) : null;


                int? id = EditarRegistro ? Convert.ToInt32(campoEntradaId.Text) : null;
                var dataCriacao = EditarRegistro ? DateTime.Parse(campoEntradaDataCriacao.Text) : Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));

                var usuario = new Usuario(
                    id,
                    campoEntradaNome.Text,
                    campoEntradaSenha.Text,
                    campoEntradaEmail.Text,
                    dataNascimento,
                    dataCriacao);

                bool validarFormulario = ValidarFormularioUsuario(usuario);

                if (validarFormulario) 
                {
                    if (EditarRegistro) _usuarioRepositorio.Atualizar(usuario);
                    else _usuarioRepositorio.Salvar(usuario);
                    this.Close();
                }

            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void AoClicarEmCancelarOperacao(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private bool ValidarFormularioUsuario(Usuario usuario)
        {
            try {
                string stringMensagemErro = "";
                var validRes = _usarioValidador.Validate(usuario);
                if (!validRes.IsValid)
                {
                    foreach (var erro in validRes.Errors)
                    {
                        stringMensagemErro += erro.ErrorMessage + "\n";
                    }
                    throw new Exception(stringMensagemErro);
                }
                return true;
            }
            
            catch(Exception erro) 
            {
                MessageBox.Show(erro.Message, "Erro De Validação" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void CarregarDadosParaEditarRegistro(Usuario usuario)
        {
            EditarRegistro = true;

            campoEntradaId.Text = usuario.IdUsuario.ToString();
            campoEntradaNome.Text = usuario.Nome.ToString();
            campoEntradaSenha.Text = usuario.Senha.ToString();
            campoEntradaDataNascimento.Text = usuario.DataNascimento.ToString();
            campoEntradaDataCriacao.Text = usuario.DataCriacao.ToString();
            campoEntradaEmail.Text = usuario.Email!.ToString();

            campoEntradaId.Visible = true;
            labelId.Visible = true;
            campoEntradaDataCriacao.Visible = true;
            labelDataCriacao.Visible = true;
        }
    }
}
