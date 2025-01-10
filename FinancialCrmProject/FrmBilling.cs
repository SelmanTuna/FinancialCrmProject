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
            int id = int.Parse(txtOdemeId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
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
    }
}
