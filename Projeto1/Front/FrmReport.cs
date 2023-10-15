using Projeto1.ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            InitializeComponent();

        //    using (var context = new DataContext())
        //    {
        //        //dataGridView1.DataSource = (from estoque in context.Estoque select estoque).ToList();
        //        var lista = from estoque in context.Estoque
        //                    join department in context.Deparments
        //                    on estoque.IdDepartment equals department.IdDepartment
        //                    into estoqueGrupo
        //                    from department in estoqueGrupo.DefaultIfEmpty()
        //                    select new { department, estoque, };
        //        ConfigurarGrade();

        //        foreach (var item in lista)
        //            dataGridView1.Rows.Add(item.estoque.Id, item.estoque.Description,
        //                item.estoque.Unit, item.estoque.IdDepartment, item.department.Name);

        //    }
        //}

        //private void ConfigurarGrade()
        //{
        //    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
        //    dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);


        //    dataGridView1.Columns.Add("id", "Id");
        //    dataGridView1.Columns["Id"].Width = 80;
        //    dataGridView1.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        //    dataGridView1.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        //    dataGridView1.Columns.Add("Description", "Descrição");
        //    dataGridView1.Columns["Description"].HeaderText = "Descrição";
        //    dataGridView1.Columns["Description"].Width = 250;

        //    dataGridView1.Columns.Add("Unit", "Unidades");
        //    dataGridView1.Columns["Unit"].HeaderText = "Unidades";
        //    dataGridView1.Columns["Unit"].Width = 80;


        //    dataGridView1.Columns.Add("IdDepartment", "Departamento ID");
        //    dataGridView1.Columns["IdDepartment"].HeaderText = "Departamento ID";
        //    dataGridView1.Columns["IdDepartment"].Width = 150;

        //    dataGridView1.Columns.Add("Name", "Departamento");
        //    dataGridView1.Columns["Name"].HeaderText = "Departamento";
        //    dataGridView1.Columns["Name"].Width = 150;

        }



    }
}
