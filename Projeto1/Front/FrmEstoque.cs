using Projeto1.Back;
using Projeto1.ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from estoque in context.Estoque select estoque).ToList();
            }
            ConfigurarGrade();

        }
        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);
            //dataGridView1.RowHeadersWidth = 25;

            dataGridView1.Columns["Id"].HeaderText = "ID";
            dataGridView1.Columns["Id"].Width = 80;
            dataGridView1.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Description"].HeaderText = "Descrição";
            dataGridView1.Columns["Description"].Width = 250;

            dataGridView1.Columns["Unit"].HeaderText = "Unidades";
            dataGridView1.Columns["Unit"].Width = 80;

            dataGridView1.Columns["Department"].HeaderText = "Departamento";
            dataGridView1.Columns["Department"].Width = 120;

        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var frm = new FrmCadastroProduto(id))
                frm.ShowDialog();
            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from Estoque
                                            in context.Estoque
                                            select Estoque).ToList();
            }

        }

        private void AlterToolStripButton2_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            using (var frm = new FrmCadastroProduto(id))
                frm.ShowDialog();

            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from Estoque
                                            in context.Estoque
                                            select Estoque).ToList();
            }
        }

        private void ConsultToolStripButton3_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            using (var frm = new FrmCadastroProduto(id, "v"))
                frm.ShowDialog();
        }

        private void DeltoolStripButton1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            using (var frm = new FrmCadastroProduto(id, "e"))
                frm.ShowDialog();
            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from Estoque
                                            in context.Estoque
                                            select Estoque).ToList();
            }
        }

        private void ReturntoolStripButton1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Close();
        }
    }
}
