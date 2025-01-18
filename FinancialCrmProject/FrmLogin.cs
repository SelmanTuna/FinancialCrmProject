using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrmProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="admin" && txtPassword.Text == "1234")
            {
                FrmDashboard frmDas = new FrmDashboard();
                frmDas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız! Tekrar Deneyin!", "Giriş Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                txtPassword.Clear();
            }
        }
    }
}
