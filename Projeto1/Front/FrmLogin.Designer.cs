namespace Projeto1
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            toolStrip1 = new ToolStrip();
            AddToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(304, 200);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(304, 161);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(252, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.Location = new Point(244, 203);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(55, 20);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Senha:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(244, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail:";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(329, 267);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Sair";
            btnExit.UseMnemonic = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(248, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { AddToolStripButton, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // AddToolStripButton
            // 
            AddToolStripButton.Image = (Image)resources.GetObject("AddToolStripButton.Image");
            AddToolStripButton.ImageTransparentColor = Color.Magenta;
            AddToolStripButton.Name = "AddToolStripButton";
            AddToolStripButton.Size = new Size(78, 22);
            AddToolStripButton.Text = "Adicionar";
            AddToolStripButton.Click += AddToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Login";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnExit;
        private Button btnLogin;
        private ToolStrip toolStrip1;
        private ToolStripButton AddToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
    }
}