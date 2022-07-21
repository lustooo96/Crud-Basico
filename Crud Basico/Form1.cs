using Crud_Basico.Model;
using Crud_Basico.Services;

namespace Crud_Basico
{
    public partial class Form1 : Form
    {
        static List<Usuario> listaUsuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();

        }

        private void DeletarRegistro_Click(object sender, EventArgs e)
        {
            var user = new Usuario();
            ListOperation.DeleteRegisterInList(listaUsuarios, user);
        }

        private void EditarRegistro_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var usuario = new Usuario();
                usuario.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
                usuario.Nome = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                usuario.Senha = dataGridView1.CurrentRow.Cells["Senha"].Value.ToString();
                usuario.Email = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                usuario.DataNascimento = dataGridView1.CurrentRow.Cells["DataNascimento"].Value.ToString();
                usuario.DataCriacao = dataGridView1.CurrentRow.Cells["DataCriacao"].Value.ToString();
                var registerScreen = new RegisterForm(usuario);
                registerScreen.Show();
            }
           

        }
        private void NovoRegistro_Click(object sender, EventArgs e)
        {
            var registerScreen = new RegisterForm(listaUsuarios);

            if (Application.OpenForms["RegisterForm"] == null) 
            {
                registerScreen.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (listaUsuarios.Count > 0) 
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaUsuarios.ToList();
            }
            
        }
    }
}