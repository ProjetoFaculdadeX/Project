using Projeto1.Back;
using Projeto1.ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Projeto1
{
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto(int id, string operacao = "a")
        {
            InitializeComponent();
            PopularDepartment();

            if (id != 0)
                ObterProduto(id);

            //Visualizar
            if (operacao == "v")
            {
                Text = "Visualizar Produto";
                AddToolStripButton1.Visible = false;
                TravarFormulario();
            }
            //Excluir
            else if (operacao == "e")
            {
                Text = "Excluir produto";
                AddToolStripButton1.Visible = false;
                DelToolStripButton2.Visible = true;
                TravarFormulario();
            }
        }

        private void TravarFormulario()
        {
            txtdescription.ReadOnly = true;
            txtid.ReadOnly = true;
            txtlote.ReadOnly = true;
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
                    cmbDepartment.ValueMember = "Name";
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
                        txtunits.Text = product.Unit!.ToString();
                        txtlote.Text = product.Lote;
                        cmbDepartment.SelectedValue = product.Department;

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
            var product = new Estoque();

            product.Id = Convert.ToInt32("0" + txtid.Text);
            product.Description = txtdescription.Text;
            product.Unit = txtunits.Text;
            product.Lote = txtlote.Text;
            product.Department = Convert.ToString(cmbDepartment.SelectedValue);
            product.Date_Created = DateTime.Now;
            product.Date_Updated = DateTime.Now;

            if (string.IsNullOrEmpty(product.Description))
            {
                MessageBox.Show("Descrição não pode estar em branco!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(product.Unit))
            {
                MessageBox.Show("Quantidade não pode estar em branco!", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {

                using (var context = new DataContext())
                {
                    {
                        if (product.Id == 0)
                            context.Estoque.Add(product);
                        else
                            context.Entry(product).State = EntityState.Modified;

                        context.SaveChanges();
                        return true;
                    }
                }
            }

            //catch (System.Data.Entity.Core.UpdateException)
            //{
            //    MessageBox.Show("Erro ao salvar", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //catch (System.Data.Entity.Infrastructure.DbUpdateException ex) //DbContext
            //{
            //    Console.WriteLine(ex.InnerException);
            //}

            //catch (Exception ex)
            //{
            //   MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO!", "PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            catch (DbUpdateException ex)
            {
                foreach (var entry in ex.Entries)
                {
                    if (entry.Entity is Estoque)
                    {
                        var entity = (Estoque)entry.Entity;
                        // Lide com a entidade específica que causou o erro
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO!", "PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return false;

        }

        private void DelToolStripButton2_Click(object sender, EventArgs e)
        {
            if (Delete())
                Close();
        }
        private bool Delete()
        {
            try
            {
                using (var context = new DataContext())
                {
                    var product = new Estoque();

                    product.Id = Convert.ToInt32(txtid.Text);
                    var entry = context.Entry(product);

                    if (entry.State == EntityState.Detached)
                        context.Estoque.Attach(product);

                    context.Estoque.Remove(product);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("CADASTRO ATUALIZADO COM SUCESSO!", "PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
    }
}
