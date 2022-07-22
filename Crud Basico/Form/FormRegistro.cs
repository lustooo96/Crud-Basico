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
    public partial class FormRegistro : Form
    {
        bool editar = false;
        //Construtores
        public FormRegistro()
        {
            InitializeComponent();
        }

        public FormRegistro(Usuario usuario)
        {
            InitializeComponent();
            CarregarDados(usuario);
            editar = true;

        }

        //Ao clicar em um botão
        private void SaveRegister_Click(object sender, EventArgs e)
        {
            string dataAtual = DateTime.Now.ToString("dd-MM-yyyy").Replace("-","/");

            if (editar)
            {
                var usuario = new Usuario(Convert.ToInt32(textoId.Text), textoNome.Text, textoSenha.Text, textoEmail.Text, textoDataNascimento.Text, dataAtual);
                ListaUsuario.AlterarRegistro(usuario);
            }
            else
            {
                var usuario = new Usuario(ListaUsuario.ContadorDeIncide(), textoNome.Text, textoSenha.Text, textoEmail.Text, textoDataNascimento.Text, dataAtual);
                ListaUsuario.SalvarRegistro(usuario);
            }
            this.Close();
        }

        private void cancelOperation_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Quando os campos de textos mudarem
        private void TextoNome_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void TextoSenha_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void TextoEmail_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.Clear();
        }

        private void TextoDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            //Colocar um if para validar o erro antes de limpar
            errorProvider4.Clear();
        }


        //Metodos do proprio Form(Criados)
        private bool ValidarFormUser(string senha, string email, string data)
        {
            var validacaoSenha = Validacao.ValidarSenha(senha);
            var validacaoEmail = Validacao.ValidarEmail(email);

            if (!validacaoSenha || !validacaoEmail)
            {
                if (textoNome.Text == "")
                {
                    errorProvider1.SetError(textoNome, "Informe o seu nome");
                }

                if (!validacaoSenha && textoSenha.Text == "")
                {
                    errorProvider2.SetError(textoSenha, "Senha inválida");
                }

                else if (!validacaoSenha)
                {
                    errorProvider2.SetError(textoSenha, "Senha Incorreta");
                }


                if (textoEmail.Text == "")
                {
                    errorProvider3.SetError(textoEmail, "Necéssario informar um e-mail");
                }
                else if (!validacaoEmail)
                {
                    errorProvider3.SetError(textoEmail, "Email Incorreto");
                }

                return false;
            }

            return true;
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
    }
}
