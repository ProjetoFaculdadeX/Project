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
    public partial class FrmUsersInitialcs : Form
    {
        public FrmUsersInitialcs()
        {
            InitializeComponent();
        }

        private void AddUserToolStripButton1_Click(object sender, EventArgs e)
        {
            var id = 0;
            using (var frm = new frmUser(id))
                frm.ShowDialog();
        }
    }
}
