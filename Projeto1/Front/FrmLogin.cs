using Projeto1.Back;
using Projeto1.ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }
     

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var frm = new frmUser(id))
                frm.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string strlogin = txtEmail.Text;
            string strpassword = BD.Criptografar(txtPassword.Text);

            using (var context = new DataContext())
            {
               var user = context.Users.SingleOrDefault(u=> u.Email == txtEmail.Text);
                if (user != null && VerificarSenha(strpassword, user.Password!))
                {                   
                    MessageBox.Show("Login realizado com sucesso!", "Bem vindo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    LimparCampos();
                    FrmMenu frmMenu = new FrmMenu();
                    frmMenu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimparCampos();
                }
            }

        }
        private bool VerificarSenha(string senhaDigitada, string senhaArmazenada)
        {
            // Implemente a lógica de verificação de senha adequada, como hashing e comparação de hashes.
            // Lembre-se de adicionar salt para maior segurança.
            // Por questões de segurança, é altamente recomendável usar uma biblioteca de hashing, como BCrypt ou PBKDF2.
            return senhaDigitada == senhaArmazenada;
        }

        private void LimparCampos()
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
             

        }
    }
}
