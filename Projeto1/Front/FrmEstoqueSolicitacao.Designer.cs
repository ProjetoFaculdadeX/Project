namespace Projeto1.Front
{
    partial class FrmEstoqueSolicitacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueSolicitacao));
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            AddToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
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
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(12, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1132, 553);
            dataGridView1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddToolStripButton, toolStripSeparator1, DeltoolStripButton1, ReturntoolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1171, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddToolStripButton
            // 
            AddToolStripButton.Image = (Image)resources.GetObject("AddToolStripButton.Image");
            AddToolStripButton.ImageTransparentColor = Color.Magenta;
            AddToolStripButton.Name = "AddToolStripButton";
            AddToolStripButton.Size = new Size(129, 22);
            AddToolStripButton.Text = "Atender Solicitação";
            AddToolStripButton.Click += AddToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // DeltoolStripButton1
            // 
            DeltoolStripButton1.Image = (Image)resources.GetObject("DeltoolStripButton1.Image");
            DeltoolStripButton1.ImageTransparentColor = Color.Magenta;
            DeltoolStripButton1.Name = "DeltoolStripButton1";
            DeltoolStripButton1.Size = new Size(122, 22);
            DeltoolStripButton1.Text = "Excluir Solicitação";
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
            // FrmEstoqueSolicitacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 626);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstoqueSolicitacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstoqueSolicitacao";
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
        private ToolStripButton DeltoolStripButton1;
        private ToolStripButton ReturntoolStripButton1;
    }
}