using Projeto1.Back;
using Projeto1.ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.Front
{
    public partial class FrmSolicitacaoProduto : Form
    {
        public FrmSolicitacaoProduto(int id, string operacao = "a")
        {
            InitializeComponent();
            PopularDepartment();

            if (id != 0)
                ObterProduto(id);
        }
        private void TravarFormulario()
        {
            txtdescription.ReadOnly = false;
            txtid.ReadOnly = false;
            txtlote.ReadOnly = false;
            txtunits.ReadOnly = true;
            cmbDepartment.Enabled = false;
        }
        public void PopularDepartment()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var listaDepartments = from department in context.Deparments
                                           select department;

                    cmbDepartment.DataSource = listaDepartments.ToList();
                    cmbDepartment.DisplayMember = "Name";
                    cmbDepartment.ValueMember = "IdDepartment";
                    cmbDepartment.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha a localizar Departamento.\n" + ex.Message);
            }
        }

        private void ObterProduto(int id)
        {
            txtid.Text = id.ToString();
            try
            {
                using (var context = new DataContext())
                {
                    var product = context.Estoque.Find(id);
                    if (product != null)
                    {
                        txtdescription.Text = product.Description;
                        txtunits.Text = "0".ToString();
                        txtlote.Text = product.Lote;
                        cmbDepartment.SelectedValue = product.IdDepartment;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao encontrar produto.\n" + ex.Message);
            }


        }

        private void AddToolStripButton1_Click(object sender, EventArgs e)
        {
            if (Salvar())
                Close();
        }
        private bool Salvar()
        {
            var produto = new Solicitacao();

            produto.Id = Convert.ToInt32(txtid.Text);
            produto.IdEstoque = Convert.ToInt32(txtid.Text);
            produto.Description = txtdescription.Text;
            produto.Unit = Convert.ToInt32(txtunits.Text);
            produto.Lote = txtlote.Text;
            produto.IdDepartment = Convert.ToInt32(cmbDepartment.SelectedValue);
            produto.Date_Created = DateTime.Now;
            try
            {

                using (var context = new DataContext())
                {
                    {
                        if (produto.Id != 0)
                            context.Solicitacao.Add(produto);

                        context.SaveChanges();
                        return true;
                    }
                }
            }

            catch (DbUpdateException ex)
            {
                foreach (var entry in ex.Entries)
                {
                    if (entry.Entity is Solicitacao)
                    {
                        var entity = (Solicitacao)entry.Entity;
                        // Lide com a entidade específica que causou o erro
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("SOLICITAÇÃO REALIZADA COM SUCESSO!", "PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return false;

        }

        private void returntoolStripButton1_Click(object sender, EventArgs e)
        {
            Hide();
            using (var frm = new FrmSolicitacao())
                frm.ShowDialog();
        }
    }

}
