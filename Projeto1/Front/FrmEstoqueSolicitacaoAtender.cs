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
    public partial class FrmEstoqueSolicitacaoAtender : Form
    {
        public FrmEstoqueSolicitacaoAtender(int id)
        {
            InitializeComponent();
            if (id != 0)
                ObterProduto(id);
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
           using(var context = new DataContext())
            {
                var unidades = Convert.ToInt32(txtunits.Text);
                var productid = txtid.Text;
                var productsolicitacao = context.Solicitacao
                    .FirstOrDefault(s => s.Unit == unidades);
                var productestoque = context.Estoque
                    .FirstOrDefault(e => e.Unit == unidades);


                if (productid != null && productsolicitacao != null && productestoque != null)
                {
                    // Subtrai a quantidade da Solicitação da quantidade do Estoque
                    productestoque.Unit -= productsolicitacao.Unit;

                    context.SaveChanges();
                    return true;
                }
                else
                {
                    MessageBox.Show("ERRO NA INFORMAÇÃO DOS DADOS!", "Solicitação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                
            }

        }
    }
}
