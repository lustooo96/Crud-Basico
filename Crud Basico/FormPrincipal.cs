using Crud_Basico.Model;
using Crud_Basico.Services;

namespace Crud_Basico
{
    public partial class FormPrincipal : Form
    {
        
        //Construtor 
        public FormPrincipal()
        {
            InitializeComponent();
        }

        //Ao clicar em Algum botão
        private void DeletarRegistro_Click(object sender, EventArgs e)
        {
            var user = new Usuario();
            if (dataGridView1.SelectedCells.Count > 0)
            {
                    var usuario = new Usuario();
                    ListaUsuario.DeletarRegistro(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString()));

                    if(ListaUsuario.ListaUsuarios.Count == 0)
                    {
                        dataGridView1.ColumnHeadersVisible = false;
                        dataGridView1.RowHeadersVisible = false;
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ListaUsuario.ListaUsuarios.ToList();
            }
        }
        private void EditarRegistro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0 && Application.OpenForms["RegisterForm"] == null)
            {
                var usuario = new Usuario();
                usuario.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                usuario.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                usuario.Senha = dataGridView1.CurrentRow.Cells["Senha"].Value.ToString();
                usuario.Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                usuario.DataNascimento = dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString();
                usuario.DataCriacao = dataGridView1.CurrentRow.Cells["DataCriacao"].Value.ToString();
                var registerScreen = new FormRegistro(usuario);

                registerScreen.Show();
            }
        }

        private void NovoRegistro_Click(object sender, EventArgs e)
        {
            var registerScreen = new FormRegistro();

            if (Application.OpenForms["RegisterForm"] == null) 
            {
                registerScreen.Show();
            }
        }

        private void FecharTela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Medodo
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (ListaUsuario.ListaUsuarios.Count > 0)
            {
                if (ListaUsuario.ListaUsuarios.Count > 0 && !dataGridView1.ColumnHeadersVisible && !dataGridView1.RowHeadersVisible)
                {
                    dataGridView1.ColumnHeadersVisible = true;
                    dataGridView1.RowHeadersVisible = true;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ListaUsuario.ListaUsuarios.ToList();
                dataGridView1.Columns["Senha"].Visible = false;
            }
        }
    }
}