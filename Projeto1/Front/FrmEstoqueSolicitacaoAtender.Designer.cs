namespace Projeto1.Front
{
    partial class FrmEstoqueSolicitacaoAtender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueSolicitacaoAtender));
            cmbDepartment = new ComboBox();
            label5 = new Label();
            toolStrip1 = new ToolStrip();
            AddToolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            DelToolStripButton2 = new ToolStripButton();
            returntoolStripButton1 = new ToolStripButton();
            txtunits = new TextBox();
            txtlote = new TextBox();
            txtdescription = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtid = new TextBox();
            label6 = new Label();
            txtIdEstoque = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(126, 181);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(121, 23);
            cmbDepartment.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 189);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 29;
            label5.Text = "Departamento:";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddToolStripButton1, toolStripSeparator1, toolStripSeparator2, DelToolStripButton2, returntoolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(508, 25);
            toolStrip1.TabIndex = 28;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddToolStripButton1
            // 
            AddToolStripButton1.Image = (Image)resources.GetObject("AddToolStripButton1.Image");
            AddToolStripButton1.ImageTransparentColor = Color.Magenta;
            AddToolStripButton1.Name = "AddToolStripButton1";
            AddToolStripButton1.Size = new Size(69, 22);
            AddToolStripButton1.Text = "Atender";
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
            // returntoolStripButton1
            // 
            returntoolStripButton1.Alignment = ToolStripItemAlignment.Right;
            returntoolStripButton1.Image = (Image)resources.GetObject("returntoolStripButton1.Image");
            returntoolStripButton1.ImageTransparentColor = Color.Magenta;
            returntoolStripButton1.Name = "returntoolStripButton1";
            returntoolStripButton1.Size = new Size(57, 22);
            returntoolStripButton1.Text = "Voltar";
            returntoolStripButton1.Click += returntoolStripButton1_Click;
            // 
            // txtunits
            // 
            txtunits.Location = new Point(126, 152);
            txtunits.MaxLength = 9;
            txtunits.Name = "txtunits";
            txtunits.Size = new Size(56, 23);
            txtunits.TabIndex = 27;
            txtunits.TextAlign = HorizontalAlignment.Center;
            // 
            // txtlote
            // 
            txtlote.CharacterCasing = CharacterCasing.Upper;
            txtlote.Location = new Point(126, 123);
            txtlote.MaxLength = 7;
            txtlote.Name = "txtlote";
            txtlote.Size = new Size(100, 23);
            txtlote.TabIndex = 26;
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(126, 89);
            txtdescription.MaxLength = 70;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(309, 23);
            txtdescription.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 160);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 24;
            label4.Text = "Quantidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 131);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 23;
            label3.Text = "Lote:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 97);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 22;
            label2.Text = "Descrição Produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 39);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 21;
            label1.Text = "ID:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // txtid
            // 
            txtid.Location = new Point(126, 31);
            txtid.MaxLength = 7;
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(44, 23);
            txtid.TabIndex = 31;
            txtid.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 68);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 32;
            label6.Text = "Id Estoque:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtIdEstoque
            // 
            txtIdEstoque.Location = new Point(126, 60);
            txtIdEstoque.MaxLength = 7;
            txtIdEstoque.Name = "txtIdEstoque";
            txtIdEstoque.ReadOnly = true;
            txtIdEstoque.Size = new Size(44, 23);
            txtIdEstoque.TabIndex = 33;
            txtIdEstoque.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmEstoqueSolicitacaoAtender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 313);
            Controls.Add(label6);
            Controls.Add(txtIdEstoque);
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
            Name = "FrmEstoqueSolicitacaoAtender";
            Text = "FrmEstoqueSolicitacaoAtender";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDepartment;
        private Label label5;
        private ToolStrip toolStrip1;
        private ToolStripButton AddToolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton DelToolStripButton2;
        private ToolStripButton returntoolStripButton1;
        private TextBox txtunits;
        private TextBox txtlote;
        private TextBox txtdescription;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtid;
        private Label label6;
        private TextBox txtIdEstoque;
    }
}