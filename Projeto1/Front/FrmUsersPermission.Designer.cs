namespace Projeto1.Front
{
    partial class FrmUsersPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersPermission));
            toolStrip1 = new ToolStrip();
            RegistreToolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            DeleteToolStripButton2 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { RegistreToolStripButton1, toolStripSeparator1, DeleteToolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // RegistreToolStripButton1
            // 
            RegistreToolStripButton1.Image = (Image)resources.GetObject("RegistreToolStripButton1.Image");
            RegistreToolStripButton1.ImageTransparentColor = Color.Magenta;
            RegistreToolStripButton1.Name = "RegistreToolStripButton1";
            RegistreToolStripButton1.Size = new Size(107, 22);
            RegistreToolStripButton1.Text = "Cadastrar Setor";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // DeleteToolStripButton2
            // 
            DeleteToolStripButton2.Image = (Image)resources.GetObject("DeleteToolStripButton2.Image");
            DeleteToolStripButton2.ImageTransparentColor = Color.Magenta;
            DeleteToolStripButton2.Name = "DeleteToolStripButton2";
            DeleteToolStripButton2.Size = new Size(92, 22);
            DeleteToolStripButton2.Text = "Excluir Setor";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 389);
            dataGridView1.TabIndex = 1;
            // 
            // FrmUsersPermission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "FrmUsersPermission";
            Text = "Permisões de usuario";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton RegistreToolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton DeleteToolStripButton2;
        private DataGridView dataGridView1;
    }
}