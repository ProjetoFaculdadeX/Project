namespace Projeto1.Front
{
    partial class FrmSolicitacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitacao));
            toolStrip1 = new ToolStrip();
            AddToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ReturntoolStripButton1 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddToolStripButton, toolStripSeparator1, ReturntoolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1096, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddToolStripButton
            // 
            AddToolStripButton.Image = (Image)resources.GetObject("AddToolStripButton.Image");
            AddToolStripButton.ImageTransparentColor = Color.Magenta;
            AddToolStripButton.Name = "AddToolStripButton";
            AddToolStripButton.Size = new Size(69, 22);
            AddToolStripButton.Text = "Solicitar";
            AddToolStripButton.Click += AddToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ReturntoolStripButton1
            // 
            ReturntoolStripButton1.Alignment = ToolStripItemAlignment.Right;
            ReturntoolStripButton1.Image = (Image)resources.GetObject("ReturntoolStripButton1.Image");
            ReturntoolStripButton1.ImageTransparentColor = Color.Magenta;
            ReturntoolStripButton1.Name = "ReturntoolStripButton1";
            ReturntoolStripButton1.Size = new Size(57, 22);
            ReturntoolStripButton1.Text = "Voltar";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1041, 456);
            dataGridView1.TabIndex = 3;
            // 
            // FrmSolicitacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1096, 552);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "FrmSolicitacao";
            Text = "FrmSolicitacao";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton AddToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ReturntoolStripButton1;
        private DataGridView dataGridView1;
    }
}