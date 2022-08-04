namespace CrudBasico
{
    partial class FormRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.campoEntradaDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.campoEntradaDataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.labelDataCriacao = new System.Windows.Forms.Label();
            this.campoEntradaSenha = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.campoEntradaEmail = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.campoEntradaId = new System.Windows.Forms.TextBox();
            this.campoEntradaNome = new System.Windows.Forms.TextBox();
            this.cancelarOperacao = new System.Windows.Forms.Button();
            this.salvarRegistro = new System.Windows.Forms.Button();
            this.erroNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroData = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.campoEntradaDataNascimento);
            this.panel1.Controls.Add(this.campoEntradaDataCriacao);
            this.panel1.Controls.Add(this.labelDataCriacao);
            this.panel1.Controls.Add(this.campoEntradaSenha);
            this.panel1.Controls.Add(this.labelDataNascimento);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.campoEntradaEmail);
            this.panel1.Controls.Add(this.labelSenha);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.campoEntradaId);
            this.panel1.Controls.Add(this.campoEntradaNome);
            this.panel1.Controls.Add(this.cancelarOperacao);
            this.panel1.Controls.Add(this.salvarRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 381);
            this.panel1.TabIndex = 1;
            // 
            // campoEntradaDataNascimento
            // 
            this.campoEntradaDataNascimento.Location = new System.Drawing.Point(129, 213);
            this.campoEntradaDataNascimento.Mask = "00/00/0000";
            this.campoEntradaDataNascimento.Name = "campoEntradaDataNascimento";
            this.campoEntradaDataNascimento.Size = new System.Drawing.Size(91, 23);
            this.campoEntradaDataNascimento.TabIndex = 5;
            this.campoEntradaDataNascimento.ValidatingType = typeof(System.DateTime);
            this.campoEntradaDataNascimento.TextChanged += new System.EventHandler(this.QuandoCampoDeEntradaDataNascimentoMudar);
            // 
            // campoEntradaDataCriacao
            // 
            this.campoEntradaDataCriacao.Location = new System.Drawing.Point(129, 261);
            this.campoEntradaDataCriacao.Mask = "00/00/0000";
            this.campoEntradaDataCriacao.Name = "campoEntradaDataCriacao";
            this.campoEntradaDataCriacao.ReadOnly = true;
            this.campoEntradaDataCriacao.Size = new System.Drawing.Size(91, 23);
            this.campoEntradaDataCriacao.TabIndex = 6;
            this.campoEntradaDataCriacao.ValidatingType = typeof(System.DateTime);
            this.campoEntradaDataCriacao.Visible = false;
            // 
            // labelDataCriacao
            // 
            this.labelDataCriacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataCriacao.AutoSize = true;
            this.labelDataCriacao.Location = new System.Drawing.Point(36, 269);
            this.labelDataCriacao.Name = "labelDataCriacao";
            this.labelDataCriacao.Size = new System.Drawing.Size(74, 15);
            this.labelDataCriacao.TabIndex = 19;
            this.labelDataCriacao.Text = "Data Criação";
            this.labelDataCriacao.Visible = false;
            // 
            // campoEntradaSenha
            // 
            this.campoEntradaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.campoEntradaSenha.Location = new System.Drawing.Point(129, 123);
            this.campoEntradaSenha.MaxLength = 14;
            this.campoEntradaSenha.Name = "campoEntradaSenha";
            this.campoEntradaSenha.PasswordChar = '*';
            this.campoEntradaSenha.Size = new System.Drawing.Size(246, 23);
            this.campoEntradaSenha.TabIndex = 3;
            this.campoEntradaSenha.TextChanged += new System.EventHandler(this.QuandoCampoDeEntradaSenhaMudar);
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(12, 213);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(98, 15);
            this.labelDataNascimento.TabIndex = 17;
            this.labelDataNascimento.Text = "Data Nascimento";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(64, 167);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 15);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "E-mail*";
            // 
            // campoEntradaEmail
            // 
            this.campoEntradaEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.campoEntradaEmail.Location = new System.Drawing.Point(129, 164);
            this.campoEntradaEmail.MaximumSize = new System.Drawing.Size(246, 23);
            this.campoEntradaEmail.MaxLength = 30;
            this.campoEntradaEmail.Name = "campoEntradaEmail";
            this.campoEntradaEmail.Size = new System.Drawing.Size(246, 23);
            this.campoEntradaEmail.TabIndex = 4;
            this.campoEntradaEmail.TextChanged += new System.EventHandler(this.QuandoCampoDeEntradaEmailMudar);
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(66, 126);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(44, 15);
            this.labelSenha.TabIndex = 9;
            this.labelSenha.Text = "Senha*";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(65, 81);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 15);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome*";
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(93, 35);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(17, 15);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id";
            this.labelId.Visible = false;
            // 
            // campoEntradaId
            // 
            this.campoEntradaId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.campoEntradaId.Location = new System.Drawing.Point(132, 32);
            this.campoEntradaId.MaxLength = 10000;
            this.campoEntradaId.Name = "campoEntradaId";
            this.campoEntradaId.ReadOnly = true;
            this.campoEntradaId.Size = new System.Drawing.Size(65, 23);
            this.campoEntradaId.TabIndex = 1;
            this.campoEntradaId.Visible = false;
            // 
            // campoEntradaNome
            // 
            this.campoEntradaNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.campoEntradaNome.Location = new System.Drawing.Point(129, 78);
            this.campoEntradaNome.MaxLength = 30;
            this.campoEntradaNome.Name = "campoEntradaNome";
            this.campoEntradaNome.Size = new System.Drawing.Size(246, 23);
            this.campoEntradaNome.TabIndex = 2;
            this.campoEntradaNome.TextChanged += new System.EventHandler(this.QuandoCampoDeEntradaEmailMudar);
            // 
            // cancelarOperacao
            // 
            this.cancelarOperacao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelarOperacao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelarOperacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarOperacao.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelarOperacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelarOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarOperacao.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelarOperacao.Location = new System.Drawing.Point(242, 309);
            this.cancelarOperacao.Name = "cancelarOperacao";
            this.cancelarOperacao.Size = new System.Drawing.Size(75, 27);
            this.cancelarOperacao.TabIndex = 8;
            this.cancelarOperacao.Text = "Cancelar";
            this.cancelarOperacao.UseVisualStyleBackColor = false;
            this.cancelarOperacao.Click += new System.EventHandler(this.AoClicarEmCancelarOperacao);
            // 
            // salvarRegistro
            // 
            this.salvarRegistro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.salvarRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.salvarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salvarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.salvarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.salvarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salvarRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salvarRegistro.ForeColor = System.Drawing.Color.MidnightBlue;
            this.salvarRegistro.Location = new System.Drawing.Point(145, 309);
            this.salvarRegistro.Name = "salvarRegistro";
            this.salvarRegistro.Size = new System.Drawing.Size(75, 27);
            this.salvarRegistro.TabIndex = 7;
            this.salvarRegistro.Text = "Salvar";
            this.salvarRegistro.UseVisualStyleBackColor = false;
            this.salvarRegistro.Click += new System.EventHandler(this.AoClicarEmSalvarRegistro);
            // 
            // erroNome
            // 
            this.erroNome.ContainerControl = this;
            // 
            // erroSenha
            // 
            this.erroSenha.ContainerControl = this;
            // 
            // erroEmail
            // 
            this.erroEmail.ContainerControl = this;
            // 
            // erroData
            // 
            this.erroData.ContainerControl = this;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 381);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erroData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label labelEmail;
        private TextBox campoEntradaEmail;
        private Label labelSenha;
        private Label labelNome;
        private Label labelId;
        private TextBox campoEntradaId;
        private TextBox campoEntradaNome;
        private Button cancelarOperacao;
        private Button salvarRegistro;
        private Label labelDataCriacao;
        private TextBox campoEntradaSenha;
        private Label labelDataNascimento;
        private ErrorProvider erroNome;
        private ErrorProvider erroSenha;
        private ErrorProvider erroEmail;
        private ErrorProvider erroData;
        private MaskedTextBox campoEntradaDataCriacao;
        private MaskedTextBox campoEntradaDataNascimento;
    }
}