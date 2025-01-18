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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            var values = db.Users.ToList();
            dataGridView1.DataSource = values;

            btnSetting.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmdas = new FrmDashboard();
            frmdas.Show();
            this.Hide();
        }

        private void btnBankTransaction_Click(object sender, EventArgs e)
        {
            FrmBankTransaction frmBnkTr = new FrmBankTransaction();
            frmBnkTr.Show();
            this.Hide();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpn = new FrmSpendings();
            frmSpn.Show();
            this.Hide();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            FrmBilling frmbl = new FrmBilling();
            frmbl.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmbnk = new FrmBanks();
            frmbnk.Show();
            this.Hide();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmcat = new FrmCategories();
            frmcat.Show();
            this.Hide();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            int password = int.Parse(txtPassword.Text);

            Users user = new Users();

            user.Username = userName;
            user.Password = password.ToString();

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Kullanıcı Ekleme İşlemi Başarılı.", "Kullanıcı Ekleme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Users.ToList();
            dataGridView1.DataSource = values2;

        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtUserId.Text.ToString()); 

            var removeValue=db.Users.Find(id);
            db.Users.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("Kullanıcı Silme İşlemi Başarılı.", "Kullanıcı Silme Sayfası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var values3 = db.Users.ToList();
            dataGridView1.DataSource = values3;
        }
    }
}
