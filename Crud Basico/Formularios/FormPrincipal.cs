using Crud_Basico.Modelo;
using Crud_Basico.Servicos;

namespace Crud_Basico
{
    public partial class FormPrincipal : Form
    {
        UsuarioOperacao OperacaoDoUsuario;
        public FormPrincipal()
        {
            InitializeComponent();
            OperacaoDoUsuario = new UsuarioOperacao();
        }

        private void DeletarRegistro_Clicar(object sender, EventArgs e)
        {
            try
            {

                var usuarioSelecionado = ObterUsuarioSelecionado();
                string mensagemDeletarUsuario = "Voc� realmente deseja deletar esse usu�rio ?";
                string TituloDaMensagem = "Deletar Usu�rio";

                DialogResult resultadoAlertaDeDeletar = MessageBox.Show(mensagemDeletarUsuario, TituloDaMensagem,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultadoAlertaDeDeletar == DialogResult.Yes)
                {
                    OperacaoDoUsuario.Remover(usuarioSelecionado.Id);
                    dataGridView1.DataSource = OperacaoDoUsuario.Listar();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }

        }

        private Usuario ObterUsuarioSelecionado()
        {
            if (dataGridView1.SelectedCells.Count == decimal.Zero) throw new Exception("Selecione um usu�rio");
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
                dataGridView1.DataSource = OperacaoDoUsuario.Listar();
                dataGridView1.Columns["Senha"].Visible = false;
            }
            catch (Exception erro) 
            {
                MessageBox.Show(erro.Message, "Ocorreu um Erro");
            }

        }
    }
}