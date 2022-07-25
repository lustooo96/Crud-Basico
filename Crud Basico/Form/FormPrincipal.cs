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
            if (dataGridView1.SelectedCells.Count > 0)
            {
                    UsuarioOperacao.DeletarRegistro(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString()));
                    if(UsuarioAcao.QuantidadeUsuarios() == 0)
                    {
                        dataGridView1.ColumnHeadersVisible = false;
                        dataGridView1.RowHeadersVisible = false;
                    }
                    dataGridView1.DataSource = UsuarioView.MostrarUsuarios();
            }
            else 
            {
                MessageBox.Show("Selecione um usuário para deletar", "Deletar Usuário");
            }
        }
        private void EditarRegistro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var usuario = new Usuario();
                usuario.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                usuario.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                usuario.Senha = dataGridView1.CurrentRow.Cells["Senha"].Value.ToString();
                usuario.Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                usuario.DataNascimento = dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString();
                usuario.DataCriacao = dataGridView1.CurrentRow.Cells["DataCriacao"].Value.ToString();
                var registerScreen = new FormRegistro(usuario);

                registerScreen.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Selecione um usuário para editar","Editar Usuário");
            }
        }
        private void NovoRegistro_Click(object sender, EventArgs e)
        {
            var registerScreen = new FormRegistro();
            registerScreen.ShowDialog();
        }
        private void FecharTela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            if (UsuarioAcao.QuantidadeUsuarios() > 0)
            {
                if (!dataGridView1.ColumnHeadersVisible && !dataGridView1.RowHeadersVisible)
                {
                    dataGridView1.ColumnHeadersVisible = true;
                    dataGridView1.RowHeadersVisible = true;
                }
                dataGridView1.DataSource = UsuarioView.MostrarUsuarios();
                dataGridView1.Columns["Senha"].Visible = false;
            }
        }
    }
}