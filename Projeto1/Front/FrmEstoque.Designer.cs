namespace Projeto1
{
    partial class FrmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            AddToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            AlterToolStripButton2 = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            ConsultToolStripButton3 = new ToolStripButton();
            DeltoolStripButton1 = new ToolStripButton();
            ReturntoolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1041, 456);
            dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddToolStripButton, toolStripSeparator1, toolStripSeparator2, AlterToolStripButton2, toolStripSeparator3, toolStripSeparator4, ConsultToolStripButton3, DeltoolStripButton1, ReturntoolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1065, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddToolStripButton
            // 
            AddToolStripButton.Image = (Image)resources.GetObject("AddToolStripButton.Image");
            AddToolStripButton.ImageTransparentColor = Color.Magenta;
            AddToolStripButton.Name = "AddToolStripButton";
            AddToolStripButton.Size = new Size(75, 22);
            AddToolStripButton.Text = "Adiconar";
            AddToolStripButton.Click += AddToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // AlterToolStripButton2
            // 
            AlterToolStripButton2.Image = (Image)resources.GetObject("AlterToolStripButton2.Image");
            AlterToolStripButton2.ImageTransparentColor = Color.Magenta;
            AlterToolStripButton2.Name = "AlterToolStripButton2";
            AlterToolStripButton2.Size = new Size(62, 22);
            AlterToolStripButton2.Text = "Alterar";
            AlterToolStripButton2.Click += AlterToolStripButton2_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // ConsultToolStripButton3
            // 
            ConsultToolStripButton3.Image = (Image)resources.GetObject("ConsultToolStripButton3.Image");
            ConsultToolStripButton3.ImageTransparentColor = Color.Magenta;
            ConsultToolStripButton3.Name = "ConsultToolStripButton3";
            ConsultToolStripButton3.Size = new Size(76, 22);
            ConsultToolStripButton3.Text = "Visualizar";
            ConsultToolStripButton3.Click += ConsultToolStripButton3_Click;
            // 
            // DeltoolStripButton1
            // 
            DeltoolStripButton1.Image = (Image)resources.GetObject("DeltoolStripButton1.Image");
            DeltoolStripButton1.ImageTransparentColor = Color.Magenta;
            DeltoolStripButton1.Name = "DeltoolStripButton1";
            DeltoolStripButton1.Size = new Size(62, 22);
            DeltoolStripButton1.Text = "Excluir";
            DeltoolStripButton1.Click += DeltoolStripButton1_Click;
            // 
            // ReturntoolStripButton1
            // 
            ReturntoolStripButton1.Alignment = ToolStripItemAlignment.Right;
            ReturntoolStripButton1.Image = (Image)resources.GetObject("ReturntoolStripButton1.Image");
            ReturntoolStripButton1.ImageTransparentColor = Color.Magenta;
            ReturntoolStripButton1.Name = "ReturntoolStripButton1";
            ReturntoolStripButton1.Size = new Size(57, 22);
            ReturntoolStripButton1.Text = "Voltar";
            ReturntoolStripButton1.Click += ReturntoolStripButton1_Click;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1065, 496);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmEstoque";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton AddToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton AlterToolStripButton2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton ConsultToolStripButton3;
        private ToolStripButton DeltoolStripButton1;
        private ToolStripButton ReturntoolStripButton1;
    }
}