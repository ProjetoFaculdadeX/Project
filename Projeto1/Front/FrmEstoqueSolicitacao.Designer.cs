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
            dataGridViewSolicitacao = new DataGridView();
            toolStrip1 = new ToolStrip();
            AddToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            DeltoolStripButton1 = new ToolStripButton();
            ReturntoolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitacao).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSolicitacao
            // 
            dataGridViewSolicitacao.AllowUserToAddRows = false;
            dataGridViewSolicitacao.AllowUserToDeleteRows = false;
            dataGridViewSolicitacao.AllowUserToResizeColumns = false;
            dataGridViewSolicitacao.AllowUserToResizeRows = false;
            dataGridViewSolicitacao.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewSolicitacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSolicitacao.ImeMode = ImeMode.NoControl;
            dataGridViewSolicitacao.Location = new Point(12, 50);
            dataGridViewSolicitacao.Name = "dataGridViewSolicitacao";
            dataGridViewSolicitacao.ReadOnly = true;
            dataGridViewSolicitacao.RowTemplate.Height = 25;
            dataGridViewSolicitacao.Size = new Size(1132, 553);
            dataGridViewSolicitacao.TabIndex = 1;
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
            // FrmEstoqueSolicitacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 626);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridViewSolicitacao);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstoqueSolicitacao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEstoqueSolicitacao";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSolicitacao).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSolicitacao;
        private ToolStrip toolStrip1;
        private ToolStripButton AddToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton DeltoolStripButton1;
        private ToolStripButton ReturntoolStripButton1;
    }
}