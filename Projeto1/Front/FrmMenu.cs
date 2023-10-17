using Projeto1.ConnectionDB;
using Projeto1.Front;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }
        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmEstoque())
                frm.ShowDialog();
            this.Hide();
        }
        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void permissãoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmUsersPermission())
                frm.ShowDialog();
            this.Hide();
        }
    }

}