namespace Crud_Basico
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
            this.textoDataCriacao = new System.Windows.Forms.MaskedTextBox();
            this.labelDataCriacao = new System.Windows.Forms.Label();
            this.textoSenha = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.textoDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textoId = new System.Windows.Forms.TextBox();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.cancelOperation = new System.Windows.Forms.Button();
            this.saveRegister = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.textoDataCriacao);
            this.panel1.Controls.Add(this.labelDataCriacao);
            this.panel1.Controls.Add(this.textoSenha);
            this.panel1.Controls.Add(this.labelDataNascimento);
            this.panel1.Controls.Add(this.textoDataNascimento);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.textoEmail);
            this.panel1.Controls.Add(this.labelSenha);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.textoId);
            this.panel1.Controls.Add(this.textoNome);
            this.panel1.Controls.Add(this.cancelOperation);
            this.panel1.Controls.Add(this.saveRegister);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 381);
            this.panel1.TabIndex = 1;
            // 
            // textoDataCriacao
            // 
            this.textoDataCriacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textoDataCriacao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.textoDataCriacao.Location = new System.Drawing.Point(129, 258);
            this.textoDataCriacao.Mask = "00/00/0000";
            this.textoDataCriacao.Name = "textoDataCriacao";
            this.textoDataCriacao.ReadOnly = true;
            this.textoDataCriacao.Size = new System.Drawing.Size(68, 23);
            this.textoDataCriacao.TabIndex = 20;
            this.textoDataCriacao.ValidatingType = typeof(System.DateTime);
            this.textoDataCriacao.Visible = false;
            // 
            // labelDataCriacao
            // 
            this.labelDataCriacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDataCriacao.AutoSize = true;
            this.labelDataCriacao.Location = new System.Drawing.Point(36, 261);
            this.labelDataCriacao.Name = "labelDataCriacao";
            this.labelDataCriacao.Size = new System.Drawing.Size(74, 15);
            this.labelDataCriacao.TabIndex = 19;
            this.labelDataCriacao.Text = "Data Criação";
            this.labelDataCriacao.Visible = false;
            // 
            // textoSenha
            // 
            this.textoSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textoSenha.Location = new System.Drawing.Point(129, 123);
            this.textoSenha.MaxLength = 14;
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.PasswordChar = '*';
            this.textoSenha.Size = new System.Drawing.Size(246, 23);
            this.textoSenha.TabIndex = 18;
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
            // textoDataNascimento
            // 
            this.textoDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textoDataNascimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.textoDataNascimento.Location = new System.Drawing.Point(129, 210);
            this.textoDataNascimento.Mask = "00/00/0000";
            this.textoDataNascimento.Name = "textoDataNascimento";
            this.textoDataNascimento.Size = new System.Drawing.Size(68, 23);
            this.textoDataNascimento.TabIndex = 15;
            this.textoDataNascimento.ValidatingType = typeof(System.DateTime);
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
            // textoEmail
            // 
            this.textoEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textoEmail.Location = new System.Drawing.Point(129, 164);
            this.textoEmail.MaximumSize = new System.Drawing.Size(246, 23);
            this.textoEmail.MaxLength = 30;
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(246, 23);
            this.textoEmail.TabIndex = 12;
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
            // textoId
            // 
            this.textoId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textoId.Location = new System.Drawing.Point(132, 32);
            this.textoId.MaxLength = 10000;
            this.textoId.Name = "textoId";
            this.textoId.ReadOnly = true;
            this.textoId.Size = new System.Drawing.Size(65, 23);
            this.textoId.TabIndex = 6;
            this.textoId.Visible = false;
            // 
            // textoNome
            // 
            this.textoNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textoNome.Location = new System.Drawing.Point(129, 78);
            this.textoNome.MaxLength = 30;
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(246, 23);
            this.textoNome.TabIndex = 2;
            // 
            // cancelOperation
            // 
            this.cancelOperation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelOperation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelOperation.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cancelOperation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelOperation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelOperation.Location = new System.Drawing.Point(242, 309);
            this.cancelOperation.Name = "cancelOperation";
            this.cancelOperation.Size = new System.Drawing.Size(75, 27);
            this.cancelOperation.TabIndex = 1;
            this.cancelOperation.Text = "Cancelar";
            this.cancelOperation.UseVisualStyleBackColor = false;
            this.cancelOperation.Click += new System.EventHandler(this.CancelarOperacao_Click);
            // 
            // saveRegister
            // 
            this.saveRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.saveRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.saveRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saveRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveRegister.Location = new System.Drawing.Point(145, 309);
            this.saveRegister.Name = "saveRegister";
            this.saveRegister.Size = new System.Drawing.Size(75, 27);
            this.saveRegister.TabIndex = 0;
            this.saveRegister.Text = "Salvar";
            this.saveRegister.UseVisualStyleBackColor = false;
            this.saveRegister.Click += new System.EventHandler(this.SalvarRegistro_Click);
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
        private MaskedTextBox textoDataNascimento;
        private Label labelEmail;
        private TextBox textoEmail;
        private Label labelSenha;
        private Label labelNome;
        private Label labelId;
        private TextBox textoId;
        private TextBox textoNome;
        private Button cancelOperation;
        private Button saveRegister;
        private MaskedTextBox textoDataCriacao;
        private Label labelDataCriacao;
        private TextBox textoSenha;
        private Label labelDataNascimento;
        private ErrorProvider erroNome;
        private ErrorProvider erroSenha;
        private ErrorProvider erroEmail;
        private ErrorProvider erroData;
    }
}