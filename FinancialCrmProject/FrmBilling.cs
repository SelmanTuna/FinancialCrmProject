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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            btnBills.Enabled = false;
        }

        private void btnOdemeList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnOdemeCreate_Click(object sender, EventArgs e)
        {
            string title = txtOdemeHead.Text;
            decimal amount = decimal.Parse(txtOdemeAmount.Text);
            string period = txtOdemePeriot.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;

            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
            
        }

        private void btnOdemeDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtOdemeId.Text); // text den ıd yi oku, 
            var removeValue = db.Bills.Find(id); // okuduğun id yi bul ve objeye ata.

            db.Bills.Remove(removeValue); // ilgili datayı sil
            db.SaveChanges(); // db ye kaydet. 
            MessageBox.Show("Ödeme Başarılılı Bir Şekilde Silindi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnOdemeUpdate_Click(object sender, EventArgs e)
        {
            string title = txtOdemeHead.Text;
            decimal amount = decimal.Parse(txtOdemeAmount.Text);
            string period = txtOdemePeriot.Text;

            int id = int.Parse(txtOdemeId.Text);

            var values = db.Bills.Find(id);

            values.BillTitle = title;
            values.BillPeriod = period;
            values.BillAmount = amount;

            db.SaveChanges();
            MessageBox.Show("Ödeme İşlemi Başarıyla Güncellendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnBanks_Click(object sender, EventArgs e) 
        {
            FrmBanks frmbnk = new FrmBanks();
            frmbnk.Show();
            this.Hide();
        }

        private void btnExpense_Click(object sender, EventArgs e) 
        {
            FrmSpendings frmspn = new FrmSpendings();
            frmspn.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmdas = new FrmDashboard();
            frmdas.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmcat = new FrmCategories();
            frmcat.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frmset = new FrmSettings();
            frmset.Show();
            this.Hide();
        }

        private void btnBankTransaction_Click(object sender, EventArgs e)
        {
            FrmBankTransaction frmBnkTr = new FrmBankTransaction();
            frmBnkTr.Show();
            this.Hide();
        }
    }
}
