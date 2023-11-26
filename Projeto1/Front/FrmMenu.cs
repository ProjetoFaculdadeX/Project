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
            Hide();
            using (var frm = new FrmEstoque())
                frm.ShowDialog();
                    }
        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void permissãoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            using (var frm = new FrmUsersPermission())
                frm.ShowDialog();           
        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var id = 0;
            using (var frm = new frmUser(id))
                frm.ShowDialog();
        }

        private void solicitaçãoDeProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            using (var frm = new FrmSolicitacao())
                frm.ShowDialog();
            
        }

        private void produtosSolicitadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            using (var frm = new FrmEstoqueSolicitacao())
                frm.ShowDialog();
        }
    }
}