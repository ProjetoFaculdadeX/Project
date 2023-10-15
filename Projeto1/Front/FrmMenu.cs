using Projeto1.ConnectionDB;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void btnEstoque_Click_1(object sender, EventArgs e)
        {
            using (var frm = new FrmEstoque())
                frm.ShowDialog();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmReport())
                frm.ShowDialog();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}