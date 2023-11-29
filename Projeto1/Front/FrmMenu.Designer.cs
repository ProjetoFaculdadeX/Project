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
            produtosSolicitadosToolStripMenuItem = new ToolStripMenuItem();
            relatorioToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem1 = new ToolStripMenuItem();
            relatorioPDFEstoque = new ToolStripMenuItem();
            solicitaçãoToolStripMenuItem = new ToolStripMenuItem();
            relatorioPDFSolicitacao = new ToolStripMenuItem();
            cadastroUsuarioToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeUsuarioToolStripMenuItem = new ToolStripMenuItem();
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
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeProdutoToolStripMenuItem, solicitaçãoDeProdutoToolStripMenuItem, produtosSolicitadosToolStripMenuItem });
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
            // produtosSolicitadosToolStripMenuItem
            // 
            produtosSolicitadosToolStripMenuItem.Name = "produtosSolicitadosToolStripMenuItem";
            produtosSolicitadosToolStripMenuItem.Size = new Size(193, 22);
            produtosSolicitadosToolStripMenuItem.Text = "Produtos Solicitados";
            produtosSolicitadosToolStripMenuItem.Click += produtosSolicitadosToolStripMenuItem_Click;
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
            estoqueToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { relatorioPDFEstoque });
            estoqueToolStripMenuItem1.Name = "estoqueToolStripMenuItem1";
            estoqueToolStripMenuItem1.Size = new Size(131, 22);
            estoqueToolStripMenuItem1.Text = "Estoque";
            estoqueToolStripMenuItem1.Click += estoqueToolStripMenuItem1_Click;
            // 
            // relatorioPDFEstoque
            // 
            relatorioPDFEstoque.Name = "relatorioPDFEstoque";
            relatorioPDFEstoque.Size = new Size(145, 22);
            relatorioPDFEstoque.Text = "Relatorio PDF";
            relatorioPDFEstoque.Click += relatorioPDFToolStripMenuItem1_Click;
            // 
            // solicitaçãoToolStripMenuItem
            // 
            solicitaçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatorioPDFSolicitacao });
            solicitaçãoToolStripMenuItem.Name = "solicitaçãoToolStripMenuItem";
            solicitaçãoToolStripMenuItem.Size = new Size(131, 22);
            solicitaçãoToolStripMenuItem.Text = "Solicitação";
            solicitaçãoToolStripMenuItem.Click += solicitaçãoToolStripMenuItem_Click;
            // 
            // relatorioPDFSolicitacao
            // 
            relatorioPDFSolicitacao.Name = "relatorioPDFSolicitacao";
            relatorioPDFSolicitacao.Size = new Size(145, 22);
            relatorioPDFSolicitacao.Text = "Relatorio PDF";
            relatorioPDFSolicitacao.Click += relatorioPDFSolicitacao_Click;
            // 
            // cadastroUsuarioToolStripMenuItem
            // 
            cadastroUsuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeUsuarioToolStripMenuItem });
            cadastroUsuarioToolStripMenuItem.Name = "cadastroUsuarioToolStripMenuItem";
            cadastroUsuarioToolStripMenuItem.Size = new Size(64, 20);
            cadastroUsuarioToolStripMenuItem.Text = "Usuarios";
            // 
            // cadastroDeUsuarioToolStripMenuItem
            // 
            cadastroDeUsuarioToolStripMenuItem.Name = "cadastroDeUsuarioToolStripMenuItem";
            cadastroDeUsuarioToolStripMenuItem.Size = new Size(180, 22);
            cadastroDeUsuarioToolStripMenuItem.Text = "Cadastro de usuario";
            cadastroDeUsuarioToolStripMenuItem.Click += cadastroDeUsuarioToolStripMenuItem_Click;
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
            Load += FrmMenu_Load;
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
        private ToolStripMenuItem sairDoSistemaToolStripMenuItem;
        private ToolStripMenuItem produtosSolicitadosToolStripMenuItem;
        private ToolStripMenuItem relatorioPDFSolicitacao;
        private ToolStripMenuItem relatorioPDFEstoque;
    }
}