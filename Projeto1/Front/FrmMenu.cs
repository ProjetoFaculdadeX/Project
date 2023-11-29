using DocumentFormat.OpenXml.Drawing;
using iText.Kernel.Pdf;
using Projeto1.Back;
using Projeto1.ConnectionDB;
using Projeto1.Front;
using System.Data.Entity;
using System.Reflection.Metadata;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iText.Layout;
using iText.Layout.Element;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Document = iText.Layout.Document;
using Paragraph = iText.Layout.Element.Paragraph;
using Table = iText.Layout.Element.Table;
using iText.Layout.Properties;



namespace Projeto1
{
    public partial class FrmMenu : Form
    {
        private DataContext _context;

        public FrmMenu()
        {
            InitializeComponent();
            _context = new DataContext();
        }


        public void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            using (var frm = new FrmEstoque())
                frm.ShowDialog();
        }
        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var id = 0;
            using (var frm = new frmUser(id))
                frm.ShowDialog();
        }

        private void solicitaçãoDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            using (var frm = new FrmSolicitacao())
                frm.ShowDialog();

        }

        private void produtosSolicitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            using (var frm = new FrmEstoqueSolicitacao())
                frm.ShowDialog();
        }

        private void trocaDeSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void solicitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void GerarRelatorioPDFEstoque(string relatorioPDF, List<Estoque> listaEstoque)
        {
            try
            {
                using (var stream = new FileStream(relatorioPDF, FileMode.Create))
                {
                    MessageBox.Show("Arquivo PDF criado com sucesso!");
                    var pdfWriter = new PdfWriter(stream);
                    using (var pdf = new PdfDocument(pdfWriter))
                    {
                        var document = new Document(pdf);

                        var titulo = new Paragraph("Relatório de Estoque");
                        titulo.SetFontSize(20).SetBold().SetTextAlignment(TextAlignment.CENTER);
                        document.Add(titulo);

                        // Adiciona uma quebra de linha
                        document.Add(new Paragraph("\n"));

                        // Cria uma tabela com 6 colunas (uma para cada propriedade)
                        var table = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1, 1, 1 }));

                        table.AddHeaderCell("ID");
                        table.AddHeaderCell("Id Departamento");
                        table.AddHeaderCell("Descrição");
                        table.AddHeaderCell("Lote");
                        table.AddHeaderCell("Quantidade");
                        table.AddHeaderCell("Data de criação");


                        foreach (var item in listaEstoque)
                        {

                            table.AddCell(item.Id.ToString());
                            table.AddCell(item.IdDepartment?.ToString());
                            table.AddCell(item.Description);
                            table.AddCell(item.Lote);
                            table.AddCell(item.Unit.ToString());
                            table.AddCell(item.Date_Created.ToString("dd/MM/yyyy"));
                        }


                        document.Add(table);
                    }
                }
                MessageBox.Show("Relatório gerado com sucesso!", "RELATORIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório PDF: {ex.Message}");
            }
        }

        private void relatorioPDFToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Salvar Relatório PDF";
                    saveFileDialog.FileName = "RelatorioEstoque.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        string caminhoArquivo = saveFileDialog.FileName;

                        List<Estoque> listaEstoque = _context.Estoque.ToList();
                        GerarRelatorioPDFEstoque(caminhoArquivo, listaEstoque);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório PDF: {ex.Message}");
            }
        }

        private void relatorioPDFSolicitacao_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Salvar Relatório PDF";
                    saveFileDialog.FileName = "RelatorioSolicitacao.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        string caminhoArquivo = saveFileDialog.FileName;

                        List<Solicitacao> listasolicitacao = _context.Solicitacao.ToList();
                        GerarRelatorioPDFSolicitacao(caminhoArquivo, listasolicitacao);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório PDF: {ex.Message}");
            }
        }
        private void GerarRelatorioPDFSolicitacao(string relatorioPDF, List<Solicitacao> listasolicitacao)
        {
            try
            {
                using (var stream = new FileStream(relatorioPDF, FileMode.Create))
                {
                    var pdfWriter = new PdfWriter(stream);
                    using (var pdf = new PdfDocument(pdfWriter))
                    {
                        var document = new Document(pdf);

                        var titulo = new Paragraph("Relatório de Solicitação");
                        titulo.SetFontSize(20).SetBold().SetTextAlignment(TextAlignment.CENTER);
                        document.Add(titulo);

                        // Adiciona uma quebra de linha
                        document.Add(new Paragraph("\n"));

                        // Cria uma tabela com 6 colunas (uma para cada propriedade)
                        var table = new Table(UnitValue.CreatePercentArray(new float[] { 1, 1, 1, 1, 1, 1 }));

                        table.AddHeaderCell("ID");
                        table.AddHeaderCell("Id Departamento");
                        table.AddHeaderCell("Descrição");
                        table.AddHeaderCell("Lote");
                        table.AddHeaderCell("Quantidade");
                        table.AddHeaderCell("Data de criação");


                        foreach (var item in listasolicitacao)
                        {

                            table.AddCell(item.Id.ToString());
                            table.AddCell(item.IdDepartment?.ToString());
                            table.AddCell(item.Description);
                            table.AddCell(item.Lote);
                            table.AddCell(item.Unit.ToString());
                            table.AddCell(item.Date_Created.ToString("dd/MM/yyyy"));
                        }


                        document.Add(table);
                    }
                }
                MessageBox.Show("Relatório gerado com sucesso!", "RELATORIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar relatório PDF: {ex.Message}");
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}