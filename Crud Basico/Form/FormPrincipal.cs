using Crud_Basico.Model;
using Crud_Basico.Services;

namespace Crud_Basico
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void DeletarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                var usuarioSelecionado = ObterUsuarioSelecionado(); 
                UsuarioOperacao.DeletarRegistroUsuario(usuarioSelecionado.Id);
                dataGridView1.DataSource = UsuarioOperacao.ListarUsuarios();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ocorreu um Erro");
            }

        }

        private Usuario ObterUsuarioSelecionado()
        {
            if (dataGridView1.SelectedCells.Count == decimal.Zero) throw new Exception("Selecione um usuário");
            var linhaSelecionada = dataGridView1.CurrentCell.RowIndex;
            return dataGridView1.Rows[linhaSelecionada].DataBoundItem as Usuario;
        }

        private void EditarRegistro_Click(object sender, EventArgs e)
        {
            try
            { 
                var usuarioSelecionado = ObterUsuarioSelecionado();
                var registerScreen = new FormRegistro(usuarioSelecionado);

                registerScreen.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ocorreu um Erro");
            }
        }

        private void NovoRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                var registerScreen = new FormRegistro(null);
                registerScreen.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ocorreu um Erro");
            }
        }

        private void FecharTela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = UsuarioOperacao.ListarUsuarios();
                dataGridView1.Columns["Senha"].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ocorreu um Erro");
            }

        }
    }
}