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

namespace Projeto1.Front
{
    public partial class FrmUsersPermission : Form
    {
        public FrmUsersPermission()
        {
            InitializeComponent();
            using (var context = new DataContext())
            {
                dataGridView1.DataSource = (from Deparments in context.Deparments select Deparments).ToList();
            }
            ConfigurarGrade();
        }
        private void ConfigurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);
            //dataGridView1.RowHeadersWidth = 25;
            //

            dataGridView1.Columns["IdDepartment"].HeaderText = "ID";
            dataGridView1.Columns["IdDepartment"].Width = 80;
            dataGridView1.Columns["IdDepartment"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["IdDepartment"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Name"].HeaderText = "Department";
            dataGridView1.Columns["Name"].Width = 80;

            dataGridView1.Columns["Access"].HeaderText = "Acessos";
            dataGridView1.Columns["Access"].Width = 250;

            dataGridView1.Columns["nivel"].HeaderText = "Nivel";
            dataGridView1.Columns["nivel"].Width = 40;
            dataGridView1.Columns["nivel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["nivel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

    }
}
