namespace Projeto1
{
    partial class FrmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProduto));
            txtid = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtdescription = new TextBox();
            txtlote = new TextBox();
            txtunits = new TextBox();
            toolStrip1 = new ToolStrip();
            AddToolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            DelToolStripButton2 = new ToolStripButton();
            label5 = new Label();
            cmbDepartment = new ComboBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(128, 43);
            txtid.MaxLength = 7;
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(44, 23);
            txtid.TabIndex = 20;
            txtid.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 51);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 79);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição Produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 113);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 3;
            label3.Text = "Lote:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 142);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 4;
            label4.Text = "Quantidade:";
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(128, 71);
            txtdescription.MaxLength = 70;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(309, 23);
            txtdescription.TabIndex = 5;
            // 
            // txtlote
            // 
            txtlote.CharacterCasing = CharacterCasing.Upper;
            txtlote.Location = new Point(128, 105);
            txtlote.MaxLength = 7;
            txtlote.Name = "txtlote";
            txtlote.Size = new Size(100, 23);
            txtlote.TabIndex = 6;
            // 
            // txtunits
            // 
            txtunits.Location = new Point(128, 134);
            txtunits.MaxLength = 9;
            txtunits.Name = "txtunits";
            txtunits.Size = new Size(56, 23);
            txtunits.TabIndex = 7;
            txtunits.TextAlign = HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddToolStripButton1, toolStripSeparator1, toolStripSeparator2, DelToolStripButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(479, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddToolStripButton1
            // 
            AddToolStripButton1.Image = (Image)resources.GetObject("AddToolStripButton1.Image");
            AddToolStripButton1.ImageTransparentColor = Color.Magenta;
            AddToolStripButton1.Name = "AddToolStripButton1";
            AddToolStripButton1.Size = new Size(58, 22);
            AddToolStripButton1.Text = "Salvar";
            AddToolStripButton1.Click += AddToolStripButton1_Click;
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
            // DelToolStripButton2
            // 
            DelToolStripButton2.Image = (Image)resources.GetObject("DelToolStripButton2.Image");
            DelToolStripButton2.ImageTransparentColor = Color.Magenta;
            DelToolStripButton2.Name = "DelToolStripButton2";
            DelToolStripButton2.Size = new Size(62, 22);
            DelToolStripButton2.Text = "Excluir";
            DelToolStripButton2.Click += DelToolStripButton2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 171);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 9;
            label5.Text = "Departamento:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(128, 163);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(121, 23);
            cmbDepartment.TabIndex = 10;
            // 
            // FrmCadastroProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 381);
            Controls.Add(cmbDepartment);
            Controls.Add(label5);
            Controls.Add(toolStrip1);
            Controls.Add(txtunits);
            Controls.Add(txtlote);
            Controls.Add(txtdescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtid);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCadastroProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtdescription;
        private TextBox txtlote;
        private TextBox txtunits;
        private ToolStrip toolStrip1;
        private ToolStripButton AddToolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton DelToolStripButton2;
        private Label label5;
        private ComboBox cmbDepartment;
    }
}