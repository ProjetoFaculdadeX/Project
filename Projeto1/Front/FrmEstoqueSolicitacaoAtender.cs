using Projeto1.Back;
using Projeto1.ConnectionDB;
using Projeto1.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1.Front
{
    public partial class FrmEstoqueSolicitacaoAtender : Form
    {
        public FrmEstoqueSolicitacaoAtender(int id, string operacao = "x")
        {
            InitializeComponent();
            PopularDepartment();

            if (id != 0)
                ObterProduto(id);

            if (operacao == "e")
            {
                Text = "Excluir solicitacao";
                AddToolStripButton1.Visible = false;
                DelToolStripButton2.Visible = true;
            }
            if (operacao == "a")
            {
                Text = "Atender solicitacao";
                AddToolStripButton1.Visible = true;
                DelToolStripButton2.Visible = false;
            }

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
                    var product = context.Solicitacao.Find(id);
                    if (product != null)
                    {
                        txtdescription.Text = product.Description;
                        txtunits.Text = product.Unit!.ToString();
                        txtlote.Text = product.Lote;
                        txtIdEstoque.Text = product.IdEstoque!.ToString();
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
            var productid = txtid.Text;
            using (var context = new DataContext())
            {
                var unidades = Convert.ToInt32(txtunits.Text);
                var estoqueid = Convert.ToInt32(txtIdEstoque.Text);

                var product = context.Solicitacao.First();
                var productsolicitacao = context.Solicitacao
                    .FirstOrDefault(s => s.Unit == unidades);
                var productestoque = context.Estoque
                    .FirstOrDefault(e => e.Id == estoqueid);
                var date = context.Estoque
                    .FirstOrDefault(e => e.Date_Updated == DateTime.Now);

                if (productid != null && productsolicitacao != null && productestoque != null)
                {
                    // Subtrai a quantidade da Solicitação da quantidade do Estoque
                    productestoque.Unit -= productsolicitacao.Unit;

                    context.Entry(product).State = EntityState.Deleted;
                    context.Solicitacao.Remove(productsolicitacao);
                    //context.Entry(date?.Date_Updated).State = EntityState.Modified;                    

                    context.SaveChanges();

                    MessageBox.Show("SOLICITAÇÃO ATENDIDA!", "Solicitação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("ERRO NA INFORMAÇÃO DOS DADOS!", "Solicitação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

            }

        }

        private void returntoolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
            using (var frm = new FrmEstoqueSolicitacao())
                frm.ShowDialog();
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
                string id = txtid.Text;
                using (var context = new DataContext())
                {
                    var product = context.Solicitacao.First();

                    product.Id = Convert.ToInt32(txtid.Text);
                    var entry = context.Entry(product);

                    context.Entry(product).State = EntityState.Deleted;
                    context.Solicitacao.Remove(product);
                    MessageBox.Show("PRODUTO EXCLUIDO COM SUCESSO!", "PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    context.SaveChanges();
                    return true;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("PRODUTO NÃO PODE SER EXCLUIDO!", "PRODUTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

    }
}
