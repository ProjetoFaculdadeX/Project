namespace Projeto1
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            lblName = new Label();
            lblEmail = new Label();
            lblDepartment = new Label();
            lblPassword = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            TxtPassword = new TextBox();
            bntRegister = new Button();
            bntReturn = new Button();
            lblId = new Label();
            txtId = new TextBox();
            cmbDepartment = new ComboBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(119, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(119, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(76, 140);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(86, 15);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Departamento:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(119, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Senha:";
            // 
            // txtName
            // 
            txtName.Location = new Point(169, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(269, 23);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(169, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 23);
            txtEmail.TabIndex = 5;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(169, 167);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(160, 23);
            TxtPassword.TabIndex = 7;
            // 
            // bntRegister
            // 
            bntRegister.Location = new Point(119, 234);
            bntRegister.Name = "bntRegister";
            bntRegister.Size = new Size(75, 23);
            bntRegister.TabIndex = 8;
            bntRegister.Text = "Salvar";
            bntRegister.UseVisualStyleBackColor = true;
            bntRegister.Click += bntRegister_Click;
            // 
            // bntReturn
            // 
            bntReturn.Location = new Point(254, 234);
            bntReturn.Name = "bntReturn";
            bntReturn.Size = new Size(75, 23);
            bntReturn.TabIndex = 9;
            bntReturn.Text = "Voltar";
            bntReturn.UseVisualStyleBackColor = true;
            bntReturn.Click += bntReturn_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(140, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 10;
            lblId.Text = "ID:";
            lblId.Visible = false;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(169, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 11;
            txtId.Visible = false;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(168, 132);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(161, 23);
            cmbDepartment.TabIndex = 12;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 526);
            Controls.Add(cmbDepartment);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(bntReturn);
            Controls.Add(bntRegister);
            Controls.Add(TxtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lblPassword);
            Controls.Add(lblDepartment);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblEmail;
        private Label lblDepartment;
        private Label lblPassword;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox TxtPassword;
        private Button bntRegister;
        private Button bntReturn;
        private Label lblId;
        private TextBox txtId;
        private ComboBox cmbDepartment;
    }
}