namespace Crud_Basico
{
    partial class Form1
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
            this.fecharTela = new System.Windows.Forms.Button();
            this.novoRegistro = new System.Windows.Forms.Button();
            this.DeletarRegistro = new System.Windows.Forms.Button();
            this.editarRegistro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.fecharTela);
            this.panel2.Controls.Add(this.novoRegistro);
            this.panel2.Controls.Add(this.DeletarRegistro);
            this.panel2.Controls.Add(this.editarRegistro);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 421);
            this.panel2.TabIndex = 1;
            // 
            // fecharTela
            // 
            this.fecharTela.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fecharTela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecharTela.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.fecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fecharTela.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fecharTela.Location = new System.Drawing.Point(36, 382);
            this.fecharTela.Name = "fecharTela";
            this.fecharTela.Size = new System.Drawing.Size(75, 27);
            this.fecharTela.TabIndex = 5;
            this.fecharTela.Text = "Cancelar";
            this.fecharTela.UseVisualStyleBackColor = false;
            this.fecharTela.Click += new System.EventHandler(this.FecharTela_Click);
            // 
            // novoRegistro
            // 
            this.novoRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.novoRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.novoRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.novoRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.novoRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.novoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.novoRegistro.Location = new System.Drawing.Point(405, 382);
            this.novoRegistro.Name = "novoRegistro";
            this.novoRegistro.Size = new System.Drawing.Size(75, 27);
            this.novoRegistro.TabIndex = 4;
            this.novoRegistro.Text = "Novo";
            this.novoRegistro.UseVisualStyleBackColor = false;
            this.novoRegistro.Click += new System.EventHandler(this.NovoRegistro_Click);
            // 
            // DeletarRegistro
            // 
            this.DeletarRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeletarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DeletarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeletarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletarRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeletarRegistro.Location = new System.Drawing.Point(597, 382);
            this.DeletarRegistro.Name = "DeletarRegistro";
            this.DeletarRegistro.Size = new System.Drawing.Size(75, 27);
            this.DeletarRegistro.TabIndex = 2;
            this.DeletarRegistro.Text = "Deletar";
            this.DeletarRegistro.UseVisualStyleBackColor = false;
            this.DeletarRegistro.Click += new System.EventHandler(this.DeletarRegistro_Click);
            // 
            // editarRegistro
            // 
            this.editarRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarRegistro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.editarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editarRegistro.Location = new System.Drawing.Point(501, 382);
            this.editarRegistro.Name = "editarRegistro";
            this.editarRegistro.Size = new System.Drawing.Size(75, 27);
            this.editarRegistro.TabIndex = 1;
            this.editarRegistro.Text = "Editar";
            this.editarRegistro.UseVisualStyleBackColor = false;
            this.editarRegistro.Click += new System.EventHandler(this.EditarRegistro_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(665, 347);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 421);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Cadastro de usuarios";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Button DeletarRegistro;
        private Button editarRegistro;
        private Button novoRegistro;
        private Button fecharTela;
        private DataGridView dataGridView1;
    }
}