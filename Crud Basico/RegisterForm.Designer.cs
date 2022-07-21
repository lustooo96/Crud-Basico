namespace Crud_Basico
{
    partial class RegisterForm
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
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(404, 381);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textoDataCriacao
            // 
            this.textoDataCriacao.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.textoDataCriacao.Location = new System.Drawing.Point(107, 255);
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
            this.labelDataCriacao.AutoSize = true;
            this.labelDataCriacao.Location = new System.Drawing.Point(10, 255);
            this.labelDataCriacao.Name = "labelDataCriacao";
            this.labelDataCriacao.Size = new System.Drawing.Size(74, 15);
            this.labelDataCriacao.TabIndex = 19;
            this.labelDataCriacao.Text = "Data Criação";
            this.labelDataCriacao.Visible = false;
            // 
            // textoSenha
            // 
            this.textoSenha.Location = new System.Drawing.Point(107, 118);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.Size = new System.Drawing.Size(269, 23);
            this.textoSenha.TabIndex = 18;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(3, 210);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(98, 15);
            this.labelDataNascimento.TabIndex = 17;
            this.labelDataNascimento.Text = "Data Nascimento";
            // 
            // textoDataNascimento
            // 
            this.textoDataNascimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.textoDataNascimento.Location = new System.Drawing.Point(107, 207);
            this.textoDataNascimento.Mask = "00/00/0000";
            this.textoDataNascimento.Name = "textoDataNascimento";
            this.textoDataNascimento.Size = new System.Drawing.Size(68, 23);
            this.textoDataNascimento.TabIndex = 15;
            this.textoDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(40, 167);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 15);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "E-mail";
            // 
            // textoEmail
            // 
            this.textoEmail.Location = new System.Drawing.Point(107, 164);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(178, 23);
            this.textoEmail.TabIndex = 12;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(40, 121);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(39, 15);
            this.labelSenha.TabIndex = 9;
            this.labelSenha.Text = "Senha";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(40, 65);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(57, 24);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(17, 15);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id";
            this.labelId.Visible = false;
            // 
            // textoId
            // 
            this.textoId.Location = new System.Drawing.Point(107, 21);
            this.textoId.Name = "textoId";
            this.textoId.ReadOnly = true;
            this.textoId.Size = new System.Drawing.Size(81, 23);
            this.textoId.TabIndex = 6;
            this.textoId.Visible = false;
            this.textoId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // textoNome
            // 
            this.textoNome.Location = new System.Drawing.Point(107, 62);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(269, 23);
            this.textoNome.TabIndex = 2;
            // 
            // cancelOperation
            // 
            this.cancelOperation.Location = new System.Drawing.Point(249, 309);
            this.cancelOperation.Name = "cancelOperation";
            this.cancelOperation.Size = new System.Drawing.Size(81, 27);
            this.cancelOperation.TabIndex = 1;
            this.cancelOperation.Text = "Cancelar";
            this.cancelOperation.UseVisualStyleBackColor = true;
            this.cancelOperation.Click += new System.EventHandler(this.cancelOperation_Click);
            // 
            // saveRegister
            // 
            this.saveRegister.Location = new System.Drawing.Point(118, 309);
            this.saveRegister.Name = "saveRegister";
            this.saveRegister.Size = new System.Drawing.Size(82, 27);
            this.saveRegister.TabIndex = 0;
            this.saveRegister.Text = "Salvar";
            this.saveRegister.UseVisualStyleBackColor = true;
            this.saveRegister.Click += new System.EventHandler(this.SaveRegister_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.Text = "Novo Usuário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}