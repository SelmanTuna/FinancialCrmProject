using FinancialCrmProject.Models;
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
            this.AcceptButton = btnEnter;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Boş Olamaz!", "Login Bilgilendirme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new FinancialCrmDbEntities())
            {
                var user = context.Users
                    .FirstOrDefault(u => u.Username == username && u.Password == password);

                if(user!= null)
                {
                    FrmDashboard frmDas = new FrmDashboard();
                    frmDas.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı! Tekrar Deneyin.", "Login Bilgilendirme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
