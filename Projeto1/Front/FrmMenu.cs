using Projeto1.ConnectionDB;
using Projeto1.Front;
using System.Data.Entity;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto1
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();           
           
        }

        public void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var frm = new frmUser(id))
                frm.ShowDialog();
        }
    }
}