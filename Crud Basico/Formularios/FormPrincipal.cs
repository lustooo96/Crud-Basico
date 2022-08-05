using CrudBasico.Dominio.Interfaces;
using CrudBasico.Dominio.Modelos;
using CrudBasico.Infra.Repositorios;

namespace CrudBasico
{
    public partial class FormPrincipal : Form
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public FormPrincipal(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            InitializeComponent();
        }
        
        private void AoClicarEmDeletarRegistro(object sender, EventArgs e)
        {
            try
            {
                var usuarioSelecionado = ObterUsuarioSelecionado();
                string mensagemDeletarUsuario = "Você realmente deseja deletar esse usuário ?";
                string TituloDaMensagem = "Deletar Usuário";

                DialogResult resultadoAlertaDeDeletar = MessageBox.Show(mensagemDeletarUsuario, TituloDaMensagem,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultadoAlertaDeDeletar == DialogResult.Yes)
                {
                    _usuarioRepositorio.Remover((int)usuarioSelecionado.IdUsuario);
                    dataGridView1.DataSource = _usuarioRepositorio.Listar();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }
        }

        private Usuario ObterUsuarioSelecionado()
        {
            if (dataGridView1.SelectedCells.Count == decimal.Zero) throw new Exception("Selecione um usuário");
            var idUsuarioSelecionadoNaGrid = dataGridView1.CurrentRow.Cells["Idusuario"].Value.ToString();
            Usuario usuario = _usuarioRepositorio.BuscarUsuarioPorId(Convert.ToInt32(idUsuarioSelecionadoNaGrid));
            return usuario;
        }

        private void AoClicarEmEditarRegistro(object sender, EventArgs e)
        {
            try
            { 
                var usuarioSelecionado = ObterUsuarioSelecionado();
                var telaRegistro = new FormRegistro(usuarioSelecionado , _usuarioRepositorio);

                telaRegistro.ShowDialog();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }
        }

        private void AoClicarEmNovoRegistro(object sender, EventArgs e)
        {
            try
            {
                var telaRegistro = new FormRegistro(null , _usuarioRepositorio);
                telaRegistro.ShowDialog();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }
        }

        private void AoClicarEmFecharTela(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Ativado(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _usuarioRepositorio.Listar();
                dataGridView1.Columns["Senha"].Visible = false;
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }

        }
    }
}