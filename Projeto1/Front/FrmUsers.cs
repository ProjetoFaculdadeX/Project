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

namespace Projeto1
{
    public partial class frmUser : Form
    {
        public frmUser(int id)
        {
            InitializeComponent();          

            Department();

        }
        public void Department()
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
    
        private void bntRegister_Click(object sender, EventArgs e)
        {
            if (Salvar())
                Close();
        }

        private bool Salvar()
        {
            var user = new Users();
            using (var context = new DataContext())
                try
                {
                    user.IdUser = Convert.ToInt32("0" + txtId.Text);
                    user.Name = txtName.Text;
                    user.Email = txtEmail.Text;
                    user.Password = BD.Criptografar(TxtPassword.Text);
                    user.Deparment = Convert.ToString(cmbDepartment.SelectedValue);
                    user.DataCreat = DateTime.Now;
                    user.DataModified = DateTime.Now;

                    if (string.IsNullOrEmpty(user.Name))
                    {
                        MessageBox.Show("Nome não pode estar em branco!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    if (string.IsNullOrEmpty(user.Email))
                    {
                        MessageBox.Show("Email não pode estar em branco!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (string.IsNullOrEmpty(user.Deparment))
                    {
                        MessageBox.Show("Email não pode estar em branco!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (string.IsNullOrEmpty(user.Password))
                    {
                        MessageBox.Show("Email não pode estar em branco!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (user.IdUser == 0)
                        context.Users.Add(user);
                    else
                        context.Entry(user).State = System.Data.Entity.EntityState.Modified;

                    context.SaveChanges();
                    MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao salvar.\n" + ex.Message);
                    return false;
                }



        }

        private void bntReturn_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmLogin())
                frm.ShowDialog();
            this.Hide();
        }
    }
}


