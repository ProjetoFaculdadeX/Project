using Projeto1.ConnectionDB;
using Projeto1.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.Front
{
    public partial class FrmEstoqueSolicitacao : Form
    {
        public FrmEstoqueSolicitacao()
        {
            InitializeComponent();
            using (var context = new DataContext())
            {
                dataGridViewSolicitacao.DataSource = (context.Solicitacao).ToList();
            }
            ConfigurarGrade();

        }

        private void ConfigurarGrade()
        {
            dataGridViewSolicitacao.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridViewSolicitacao.DefaultCellStyle.Font = new Font("Arial", 9);
            //dataGridView1.RowHeadersWidth = 25;

            dataGridViewSolicitacao.Columns["Id"].HeaderText = "ID";
            dataGridViewSolicitacao.Columns["Id"].Width = 80;
            dataGridViewSolicitacao.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSolicitacao.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewSolicitacao.Columns["IdEstoque"].HeaderText = "IdEstoque";
            dataGridViewSolicitacao.Columns["IdEstoque"].Width = 80;

            dataGridViewSolicitacao.Columns["Description"].HeaderText = "Descrição";
            dataGridViewSolicitacao.Columns["Description"].Width = 250;

            dataGridViewSolicitacao.Columns["Unit"].HeaderText = "Unidades";
            dataGridViewSolicitacao.Columns["Unit"].Width = 80;

            dataGridViewSolicitacao.Columns["IdDepartment"].HeaderText = "IdDepartamento";
            dataGridViewSolicitacao.Columns["IdDepartment"].Width = 60;

            dataGridViewSolicitacao.Columns["Date_Created"].HeaderText = "Data Criação";
            dataGridViewSolicitacao.Columns["Date_Created"].Width = 120;

            dataGridViewSolicitacao.Columns["Lote"].HeaderText = "Lote";
            dataGridViewSolicitacao.Columns["Lote"].Width = 80;


            dataGridViewSolicitacao.Columns["Estoque"].HeaderText = "Estoque";
            dataGridViewSolicitacao.Columns["Estoque"].Visible = false;

        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {

            int id = 0;
            if (dataGridViewSolicitacao.CurrentRow is not null)
            {
                id = Convert.ToInt32(dataGridViewSolicitacao.CurrentRow.Cells["ID"].Value);
                using (var frm = new FrmEstoqueSolicitacaoAtender(id, "a"))
                    frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Falha a localizar solicitação.\n");
                this.Hide();
                using (var frm = new FrmMenu())
                    frm.ShowDialog();

            }

            using (var context = new DataContext())
            {
                dataGridViewSolicitacao.DataSource = (context.Solicitacao).ToList();
            }
        }

        private void ReturntoolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var frm = new FrmMenu())
                frm.ShowDialog();
        }

        private void DeltoolStripButton1_Click(object sender, EventArgs e)
        {
            int id = 0;
            if (dataGridViewSolicitacao.CurrentRow is not null)
            {
                id = Convert.ToInt32(dataGridViewSolicitacao.CurrentRow.Cells["ID"].Value);
                using (var frm = new FrmEstoqueSolicitacaoAtender(id, "e"))
                    frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Falha a localizar solicitação.\n");
                this.Hide();
                using (var frm = new FrmMenu())
                    frm.ShowDialog();

            }

            using (var context = new DataContext())
            {
                dataGridViewSolicitacao.DataSource = (context.Solicitacao).ToList();
            }

        }
    }
}
