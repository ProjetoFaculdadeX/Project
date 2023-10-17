namespace Projeto1.Front
{
    partial class FrmUsersInitialcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsersInitialcs));
            toolStrip1 = new ToolStrip();
            AddUserToolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            AlterUserToolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            DeleteUserToolStripButton3 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            ConsultUserToolStripButton4 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            PermissionUserToolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddUserToolStripButton1, toolStripSeparator1, AlterUserToolStripButton2, toolStripSeparator2, DeleteUserToolStripButton3, toolStripSeparator3, ConsultUserToolStripButton4, toolStripSeparator4, PermissionUserToolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1286, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddUserToolStripButton1
            // 
            AddUserToolStripButton1.Image = (Image)resources.GetObject("AddUserToolStripButton1.Image");
            AddUserToolStripButton1.ImageTransparentColor = Color.Magenta;
            AddUserToolStripButton1.Name = "AddUserToolStripButton1";
            AddUserToolStripButton1.Size = new Size(120, 22);
            AddUserToolStripButton1.Text = "Cadastrar Usuario";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // AlterUserToolStripButton2
            // 
            AlterUserToolStripButton2.Image = (Image)resources.GetObject("AlterUserToolStripButton2.Image");
            AlterUserToolStripButton2.ImageTransparentColor = Color.Magenta;
            AlterUserToolStripButton2.Name = "AlterUserToolStripButton2";
            AlterUserToolStripButton2.Size = new Size(62, 22);
            AlterUserToolStripButton2.Text = "Alterar";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // DeleteUserToolStripButton3
            // 
            DeleteUserToolStripButton3.Image = (Image)resources.GetObject("DeleteUserToolStripButton3.Image");
            DeleteUserToolStripButton3.ImageTransparentColor = Color.Magenta;
            DeleteUserToolStripButton3.Name = "DeleteUserToolStripButton3";
            DeleteUserToolStripButton3.Size = new Size(62, 22);
            DeleteUserToolStripButton3.Text = "Excluir";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // ConsultUserToolStripButton4
            // 
            ConsultUserToolStripButton4.Image = (Image)resources.GetObject("ConsultUserToolStripButton4.Image");
            ConsultUserToolStripButton4.ImageTransparentColor = Color.Magenta;
            ConsultUserToolStripButton4.Name = "ConsultUserToolStripButton4";
            ConsultUserToolStripButton4.Size = new Size(78, 22);
            ConsultUserToolStripButton4.Text = "Consultar";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // PermissionUserToolStripButton1
            // 
            PermissionUserToolStripButton1.Image = (Image)resources.GetObject("PermissionUserToolStripButton1.Image");
            PermissionUserToolStripButton1.ImageTransparentColor = Color.Magenta;
            PermissionUserToolStripButton1.Name = "PermissionUserToolStripButton1";
            PermissionUserToolStripButton1.Size = new Size(86, 22);
            PermissionUserToolStripButton1.Text = "Permissões";
            // 
            // FrmUsersInitialcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 606);
            Controls.Add(toolStrip1);
            Name = "FrmUsersInitialcs";
            Text = "Cadastro de Usuarios";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton AddUserToolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton AlterUserToolStripButton2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton DeleteUserToolStripButton3;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton ConsultUserToolStripButton4;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton PermissionUserToolStripButton1;
    }
}