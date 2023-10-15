namespace Projeto1
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEstoque = new Button();
            btnReport = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnEstoque
            // 
            btnEstoque.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstoque.Location = new Point(31, 93);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(194, 79);
            btnEstoque.TabIndex = 0;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click_1;
            // 
            // btnReport
            // 
            btnReport.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnReport.Location = new Point(31, 213);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(194, 79);
            btnReport.TabIndex = 1;
            btnReport.Text = "Relatorios";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.AutoSize = true;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.ImageAlign = ContentAlignment.BottomRight;
            btnClose.Location = new Point(1122, 639);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 45);
            btnClose.TabIndex = 2;
            btnClose.Text = "Sair";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1220, 696);
            Controls.Add(btnClose);
            Controls.Add(btnReport);
            Controls.Add(btnEstoque);
            Name = "FrmMenu";
            Text = "Menu Inicial";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEstoque;
        private Button btnReport;
        private Button btnClose;
    }
}