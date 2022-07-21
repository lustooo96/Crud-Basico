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
            this.button1 = new System.Windows.Forms.Button();
            this.newRegister = new System.Windows.Forms.Button();
            this.deleteRegister = new System.Windows.Forms.Button();
            this.editRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.newRegister);
            this.panel2.Controls.Add(this.deleteRegister);
            this.panel2.Controls.Add(this.editRegister);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 421);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newRegister
            // 
            this.newRegister.Location = new System.Drawing.Point(387, 386);
            this.newRegister.Name = "newRegister";
            this.newRegister.Size = new System.Drawing.Size(75, 23);
            this.newRegister.TabIndex = 4;
            this.newRegister.Text = "NOVO";
            this.newRegister.UseVisualStyleBackColor = true;
            this.newRegister.Click += new System.EventHandler(this.NovoRegistro_Click);
            // 
            // deleteRegister
            // 
            this.deleteRegister.Location = new System.Drawing.Point(597, 386);
            this.deleteRegister.Name = "deleteRegister";
            this.deleteRegister.Size = new System.Drawing.Size(75, 23);
            this.deleteRegister.TabIndex = 2;
            this.deleteRegister.Text = "DELETAR";
            this.deleteRegister.UseVisualStyleBackColor = true;
            this.deleteRegister.Click += new System.EventHandler(this.DeletarRegistro_Click);
            // 
            // editRegister
            // 
            this.editRegister.Location = new System.Drawing.Point(500, 386);
            this.editRegister.Name = "editRegister";
            this.editRegister.Size = new System.Drawing.Size(75, 23);
            this.editRegister.TabIndex = 1;
            this.editRegister.Text = "EDITAR";
            this.editRegister.UseVisualStyleBackColor = true;
            this.editRegister.Click += new System.EventHandler(this.EditarRegistro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(660, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(461, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 421);
            this.Controls.Add(this.checkedListBox1);
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
        private Button deleteRegister;
        private Button editRegister;
        private Button newRegister;
        public DataGridView dataGridView1;
        private Button button1;
        private CheckedListBox checkedListBox1;
    }
}