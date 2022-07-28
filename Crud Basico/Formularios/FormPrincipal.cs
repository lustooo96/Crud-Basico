using Crud_Basico.Modelo;
using Crud_Basico.Serviços;

namespace Crud_Basico
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void DeletarRegistro_Clicar(object sender, EventArgs e)
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
                    UsuarioOperacao.DeletarRegistroUsuario(usuarioSelecionado.Id);
                    dataGridView1.DataSource = UsuarioOperacao.ListarUsuarios();
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
            var linhaSelecionada = dataGridView1.CurrentCell.RowIndex;
            return dataGridView1.Rows[linhaSelecionada].DataBoundItem as Usuario;
        }

        private void EditarRegistro_Clicar(object sender, EventArgs e)
        {
            try
            { 
                var usuarioSelecionado = ObterUsuarioSelecionado();
                var telaRegistro = new FormRegistro(usuarioSelecionado);

                telaRegistro.ShowDialog();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }
        }

        private void NovoRegistro_Clicar(object sender, EventArgs e)
        {
            try
            {
                var telaRegistro = new FormRegistro(null);
                telaRegistro.ShowDialog();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }
        }

        private void FecharTela_Clicar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Ativado(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = UsuarioOperacao.ListarUsuarios();
                dataGridView1.Columns["Senha"].Visible = false;
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }

        }
    }
}