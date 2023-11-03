using Projeto1.ConnectionDB;
using Projeto1.Front;
using System.Data.Entity;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class FrmMenu : Form
    {
        
        public FrmMenu(string strlogin)
        {
            InitializeComponent();
            string email = strlogin;
            using (var context = new DataContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Email == email);
                if (user != null)
                {
                    string? department = user.Deparment;
                }
                else
                {
                    MessageBox.Show("erro ao localizar departamento!", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

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