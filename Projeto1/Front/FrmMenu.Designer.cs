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
            menuStrip1 = new MenuStrip();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProdutoToolStripMenuItem = new ToolStripMenuItem();
            solicitaçãoDeProdutoToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem1 = new ToolStripMenuItem();
            solicitaçãoToolStripMenuItem = new ToolStripMenuItem();
            cadastroUsuarioToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            permissãoDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
            trocaDeSenhaToolStripMenuItem = new ToolStripMenuItem();
            sairDoSistemaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { estoqueToolStripMenuItem, relatorioToolStripMenuItem, cadastroUsuarioToolStripMenuItem, sairDoSistemaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1220, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeProdutoToolStripMenuItem, solicitaçãoDeProdutoToolStripMenuItem });
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(61, 20);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // cadastroDeProdutoToolStripMenuItem
            // 
            cadastroDeProdutoToolStripMenuItem.Name = "cadastroDeProdutoToolStripMenuItem";
            cadastroDeProdutoToolStripMenuItem.Size = new Size(193, 22);
            cadastroDeProdutoToolStripMenuItem.Text = "Produtos";
            cadastroDeProdutoToolStripMenuItem.Click += cadastroDeProdutoToolStripMenuItem_Click;
            // 
            // solicitaçãoDeProdutoToolStripMenuItem
            // 
            solicitaçãoDeProdutoToolStripMenuItem.Name = "solicitaçãoDeProdutoToolStripMenuItem";
            solicitaçãoDeProdutoToolStripMenuItem.Size = new Size(193, 22);
            solicitaçãoDeProdutoToolStripMenuItem.Text = "Solicitação de Produto";
            solicitaçãoDeProdutoToolStripMenuItem.Click += solicitaçãoDeProdutoToolStripMenuItem_Click;
            // 
            // relatorioToolStripMenuItem
            // 
            relatorioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estoqueToolStripMenuItem1, solicitaçãoToolStripMenuItem });
            relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            relatorioToolStripMenuItem.Size = new Size(66, 20);
            relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // estoqueToolStripMenuItem1
            // 
            estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            estoqueToolStripMenuItem1.Size = new Size(131, 22);
            estoqueToolStripMenuItem1.Text = "Estoque";
            // 
            // solicitaçãoToolStripMenuItem
            // 
            solicitaçãoToolStripMenuItem.Name = "solicitaçãoToolStripMenuItem";
            solicitaçãoToolStripMenuItem.Size = new Size(131, 22);
            solicitaçãoToolStripMenuItem.Text = "Solicitação";
            // 
            // cadastroUsuarioToolStripMenuItem
            // 
            cadastroUsuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeUsuarioToolStripMenuItem, permissãoDeUsuarioToolStripMenuItem, trocaDeSenhaToolStripMenuItem });
            cadastroUsuarioToolStripMenuItem.Name = "cadastroUsuarioToolStripMenuItem";
            cadastroUsuarioToolStripMenuItem.Size = new Size(64, 20);
            cadastroUsuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // cadastroDeUsuarioToolStripMenuItem
            // 
            cadastroDeUsuarioToolStripMenuItem.Name = "cadastroDeUsuarioToolStripMenuItem";
            cadastroDeUsuarioToolStripMenuItem.Size = new Size(186, 22);
            cadastroDeUsuarioToolStripMenuItem.Text = "Cadastro de usuario";
            cadastroDeUsuarioToolStripMenuItem.Click += cadastroDeUsuarioToolStripMenuItem_Click;
            // 
            // permissãoDeUsuarioToolStripMenuItem
            // 
            permissãoDeUsuarioToolStripMenuItem.Name = "permissãoDeUsuarioToolStripMenuItem";
            permissãoDeUsuarioToolStripMenuItem.Size = new Size(186, 22);
            permissãoDeUsuarioToolStripMenuItem.Text = "Permissão de usuario";
            permissãoDeUsuarioToolStripMenuItem.Click += permissãoDeUsuarioToolStripMenuItem_Click;
            // 
            // trocaDeSenhaToolStripMenuItem
            // 
            trocaDeSenhaToolStripMenuItem.Name = "trocaDeSenhaToolStripMenuItem";
            trocaDeSenhaToolStripMenuItem.Size = new Size(186, 22);
            trocaDeSenhaToolStripMenuItem.Text = "Troca de senha";
            // 
            // sairDoSistemaToolStripMenuItem
            // 
            sairDoSistemaToolStripMenuItem.Name = "sairDoSistemaToolStripMenuItem";
            sairDoSistemaToolStripMenuItem.Size = new Size(99, 20);
            sairDoSistemaToolStripMenuItem.Text = "Sair do Sistema";
            sairDoSistemaToolStripMenuItem.Click += sairDoSistemaToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1220, 696);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "Menu Inicial";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProdutoToolStripMenuItem;
        private ToolStripMenuItem solicitaçãoDeProdutoToolStripMenuItem;
        private ToolStripMenuItem relatorioToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem1;
        private ToolStripMenuItem solicitaçãoToolStripMenuItem;
        private ToolStripMenuItem cadastroUsuarioToolStripMenuItem;
        private ToolStripMenuItem cadastroDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem permissãoDeUsuarioToolStripMenuItem;
        private ToolStripMenuItem trocaDeSenhaToolStripMenuItem;
        private ToolStripMenuItem sairDoSistemaToolStripMenuItem;
    }
}