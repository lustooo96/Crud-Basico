namespace Crud_Basico
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fecharTela = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editarRegistro = new System.Windows.Forms.Button();
            this.novoRegistro = new System.Windows.Forms.Button();
            this.DeletarRegistro = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 421);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fecharTela);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.editarRegistro);
            this.panel3.Controls.Add(this.novoRegistro);
            this.panel3.Controls.Add(this.DeletarRegistro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 421);
            this.panel3.TabIndex = 7;
            // 
            // fecharTela
            // 
            this.fecharTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fecharTela.AutoSize = true;
            this.fecharTela.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fecharTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecharTela.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.fecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecharTela.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fecharTela.Location = new System.Drawing.Point(12, 381);
            this.fecharTela.Name = "fecharTela";
            this.fecharTela.Size = new System.Drawing.Size(75, 28);
            this.fecharTela.TabIndex = 5;
            this.fecharTela.Text = "Sair";
            this.fecharTela.UseVisualStyleBackColor = false;
            this.fecharTela.Click += new System.EventHandler(this.FecharTela_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(665, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // editarRegistro
            // 
            this.editarRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editarRegistro.AutoSize = true;
            this.editarRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.editarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editarRegistro.Location = new System.Drawing.Point(521, 381);
            this.editarRegistro.Name = "editarRegistro";
            this.editarRegistro.Size = new System.Drawing.Size(75, 28);
            this.editarRegistro.TabIndex = 1;
            this.editarRegistro.Text = "Editar";
            this.editarRegistro.UseVisualStyleBackColor = false;
            this.editarRegistro.Click += new System.EventHandler(this.EditarRegistro_Click);
            // 
            // novoRegistro
            // 
            this.novoRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.novoRegistro.AutoSize = true;
            this.novoRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.novoRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novoRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novoRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.novoRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.novoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.novoRegistro.Location = new System.Drawing.Point(440, 381);
            this.novoRegistro.Name = "novoRegistro";
            this.novoRegistro.Size = new System.Drawing.Size(75, 28);
            this.novoRegistro.TabIndex = 4;
            this.novoRegistro.Text = "Novo";
            this.novoRegistro.UseVisualStyleBackColor = false;
            this.novoRegistro.Click += new System.EventHandler(this.NovoRegistro_Click);
            // 
            // DeletarRegistro
            // 
            this.DeletarRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletarRegistro.AutoSize = true;
            this.DeletarRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeletarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DeletarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeletarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletarRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletarRegistro.Location = new System.Drawing.Point(602, 381);
            this.DeletarRegistro.Name = "DeletarRegistro";
            this.DeletarRegistro.Size = new System.Drawing.Size(75, 28);
            this.DeletarRegistro.TabIndex = 2;
            this.DeletarRegistro.Text = "Deletar";
            this.DeletarRegistro.UseVisualStyleBackColor = false;
            this.DeletarRegistro.Click += new System.EventHandler(this.DeletarRegistro_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 421);
            this.Controls.Add(this.panel2);
            this.Name = "FormPrincipal";
            this.Text = "Cadastro de usuarios";
            this.Activated += new System.EventHandler(this.FormPrincipal_Activated);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Button fecharTela;
        private DataGridView dataGridView1;
        private Button editarRegistro;
        private Button novoRegistro;
        private Button DeletarRegistro;
    }
}