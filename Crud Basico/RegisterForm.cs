using Crud_Basico.Model;
using Crud_Basico.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Basico
{
    public partial class RegisterForm : Form
    {
        List<Usuario> listUsuario;
        bool editar = false;
        public RegisterForm()
        {
            InitializeComponent();

        }
        public RegisterForm(List<Usuario> listUsuarios)
        {

            InitializeComponent();
            listUsuario = listUsuarios;



        }
        public RegisterForm(Usuario usuario)
        {
            InitializeComponent();
            CarregarDados(usuario);
            editar = true;

        }
        private void SaveRegister_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            if (editar)
            {
                var usuario = new Usuario(Convert.ToInt32(textoId.Text),textoNome.Text, textoSenha.Text, textoEmail.Text, textoDataNascimento.Text, date);
                ListOperation.UpdateRegisterInList(listUsuario,usuario);
            }
            else 
            {
                var usuario = new Usuario(listUsuario.Count + 1,textoNome.Text, textoSenha.Text, textoEmail.Text, textoDataNascimento.Text, date);
                ListOperation.SaveRegisterInList(listUsuario,usuario);
            }
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CarregarDados(Usuario usuario) 
        {

            textoId.Text = usuario.Id.ToString();
            textoNome.Text = usuario.Nome.ToString();
            textoSenha.Text = usuario.Senha.ToString();
            textoDataNascimento.Text = usuario.DataNascimento.ToString();
            textoDataCriacao.Text = usuario.DataCriacao.ToString();
            textoEmail.Text = usuario.Email.ToString();


            textoId.Visible = true;
            labelId.Visible = true;
            textoDataCriacao.Visible = true;
            labelDataCriacao.Visible = true;
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
